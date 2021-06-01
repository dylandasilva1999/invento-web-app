using System;
using System.IO;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Collections;

namespace invento_web_app
{
    class Program
    {
        public static HttpListener listener;
        public static string url = "http://localhost:8000/";
        public static int pageViews = 0;
        public static int requestCount = 0;

        public static async Task HandleIncomingConnections()
        {
            bool runServer = true;

            while(runServer)
            {
                HttpListenerContext ctx = await listener.GetContextAsync();
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse res = ctx.Response;

                Console.WriteLine("Request #: {0}", ++requestCount);
                Console.WriteLine(req.Url.ToString());
                Console.WriteLine(req.HttpMethod);
                Console.WriteLine(req.UserHostName);
                Console.WriteLine(req.UserAgent);
				Console.WriteLine("Has entity body: " + req.HasEntityBody);
                Console.WriteLine();

				if(req.HasEntityBody) 
				{
					System.IO.Stream body = req.InputStream;
					System.Text.Encoding encoding = req.ContentEncoding;
					System.IO.StreamReader reader = new System.IO.StreamReader(body, encoding);

					if(req.ContentType != null) 
						Console.WriteLine("Client data content type: " + req.ContentType);
					Console.WriteLine("Client data content length: " + req.ContentLength64);

					Console.WriteLine("Start of data:");
					string data = reader.ReadToEnd();
					Console.WriteLine(data);
					Console.WriteLine("End of data");
					body.Close();
					reader.Close();

					string[] properties = data.Split('&');
					foreach (string curProp in properties)
					{
						string[] pair = curProp.Split('=');
						string key = pair[0].Replace('+', ' ');
						if(Inventory.GetClass(key) != null)
						{
							int value = Int32.Parse(pair[1]);
							Inventory.GetClass(key).Count = value;
						}
					}
				}

                string path = req.Url.AbsolutePath;

                if((req.HttpMethod == "POST") && path == "/shutdown")
                {
                    path = "/index.html";
                    Console.WriteLine("Shutdown Requested");
                    runServer = false;
                }

                if(path != "/favicon.ico")
                {
                    pageViews += 1;
                }

                try
                {
                    FileLoader myFileLoader = new FileLoader(path);
                    myFileLoader.ReadFile();

                    string disableSubmit = !runServer ? "disabled" : "";
                    byte[] data;

                    if(myFileLoader.mimeType.IndexOf("text/html") >= 0)
                    {
                        string input = Encoding.UTF8.GetString(myFileLoader.data);

                        if(path == "/index.html")
                        {
                            data = Encoding.UTF8.GetBytes(IndexHtmlParser.Process(input));
                        }
                        else if(path == "/about-us.html")
                        {
                            data = Encoding.UTF8.GetBytes(AboutHtmlParser.Process(input));
                        }
                        else if(path == "/contact.html")
                        {
                            data = Encoding.UTF8.GetBytes(ContactHtmlParser.Process(input));
                        }
                        else if(path == "/inventory.html")
                        {
                            data = Encoding.UTF8.GetBytes(InventoryHtmlParser.Process(input));
                        }
                        else if(path == "/resources.html")
                        {
                            data = Encoding.UTF8.GetBytes(ResourcesHtmlParser.Process(input));
                        }
                        else if(path == "/404.html")
                        {
                            data = Encoding.UTF8.GetBytes(ErrorHtmlParser.Process(input));
                        }
                        else
                        {
                            throw new FileNotFoundException("Not a page");
                        }

                    }  
                    else
                    {
                        data = myFileLoader.data;
                    }

                    res.ContentType = myFileLoader.mimeType;
                    res.ContentEncoding = Encoding.UTF8;
                    res.ContentLength64 = data.LongLength;

                    await res.OutputStream.WriteAsync(data, 0, data.Length);
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);

                    byte[] data;
                    
                    data = Encoding.UTF8.GetBytes("<h2>A 404 Page not Found</h2>");
                   
                    res.ContentType = "text/html";
                    res.ContentEncoding = Encoding.UTF8;
                    res.ContentLength64 = data.LongLength;
                    res.StatusCode = 404;

                    await res.OutputStream.WriteAsync(data, 0, data.Length);
                }
                res.Close();
            }
        }

        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            RecipeBook.Populate(); 

            Recipe woodHoeRecipe = new Recipe((Craft) Inventory.GetClass("Wood Hoe"), new Item[3,3] 
                {{Inventory.GetClass("Wood Plank"), Inventory.GetClass("Wood Plank"), null}, 
                {null, Inventory.GetClass("Stick"), null},
                {null, Inventory.GetClass("Stick"), null}});   

            RecipeBook.AddRecipe(woodHoeRecipe);

            foreach (Recipe curRecipe in RecipeBook.Recipes)
            {
                //Console.WriteLine("Recipe is " + curRecipe.Result.BlockType);
            }  

            //Console.WriteLine("Wood Plank count is: " + Inventory.GetClass("Wood Plank").Count);
           	//Inventory.GetClass("Wood Plank").Count++;
            //Console.WriteLine("Wood Plank count is: " + Inventory.GetClass("Wood Plank").Count);

            Console.WriteLine("Server Version: " + Database.GetVersion());  

            listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();                                             

            Console.WriteLine("Listening for connection on " + url);

            Task listenTask = HandleIncomingConnections();
            Console.WriteLine("before sync");
            listenTask.GetAwaiter().GetResult();
            Console.WriteLine("after sync");

            listener.Close();
        }
    }
}

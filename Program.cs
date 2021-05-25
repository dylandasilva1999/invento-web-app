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
                Console.WriteLine();

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
            ArrayList array = inventory.Items;

            listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();

            Console.WriteLine("Server Version: " + Database.GetVersion());

            Console.WriteLine("Listening for connection on " + url);

            Task listenTask = HandleIncomingConnections();
            Console.WriteLine("before sync");
            listenTask.GetAwaiter().GetResult();
            Console.WriteLine("after sync");

            listener.Close();
        }
    }
}

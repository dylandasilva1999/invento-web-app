using System;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace invento_web_app
{
    class Program
    {
        public static HttpListener listener;
        public static string url = "http://localhost:8000/";
        public static int pageViews = 0;
        public static int requestCount = 0;
        public static string pageData =
        "<!DOCTYPE>" +
        "<html>" +
        "   <head>" +
        "       <title> Http Listener Example </title>" +
        "   </head>" +
        "   <body>" +
        "       <p> Page Views: {0} </p>" +
        "       <form method=\"post\" action=\"shutdown\">" +
        "           <input type=\"submit\" value=\"Shutdown\" {1}>" +
        "       </form>" +
        "   </body>" +
        "</html>";

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

                if((req.HttpMethod == "POST") && req.Url.AbsolutePath == "/shutdown")
                {
                    Console.WriteLine("Shutdown Requested");
                    runServer = false;
                }

                if(req.Url.AbsolutePath != "/favicon.ico")
                {
                    pageViews += 1;
                }

                string disableSubmit = !runServer? "disabled" : "";
                byte[] data = Encoding.UTF8.GetBytes(String.Format(pageData, pageViews, disableSubmit));
                res.ContentType = "text/html";
                res.ContentEncoding = Encoding.UTF8;
                res.ContentLength64 = data.LongLength;

                await res.OutputStream.WriteAsync(data, 0, data.Length);
                res.Close();
            }
        }

        static void Main(string[] args)
        {
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

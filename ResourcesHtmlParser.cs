using System;
using System.Text;
using System.IO;
using HtmlAgilityPack;

namespace invento_web_app
{
    class ResourcesHtmlParser
    {
        public static string Process(string input)
        {
            //Holds the HTML document to be displayed
            HtmlDocument htmlDoc = new HtmlDocument();

            //Load the HTML Url string input
            htmlDoc.LoadHtml(input);

            //Error checking if HTML file is corrupted or formatted incorrectly
            if(htmlDoc.ParseErrors != null || htmlDoc.DocumentNode == null)
            {
                int count = 0;

                foreach(var htmlParseError in htmlDoc.ParseErrors)
                {
                    count++;
                    Console.WriteLine("Parse Error: " + htmlParseError.Reason);
                }

                if(count > 0)
                {
                    throw new FileNotFoundException("File corrupt!");
                }
            }

            HtmlNode resourcesNode = htmlDoc.GetElementbyId("resourcesItems");
            Console.WriteLine(resourcesNode.OuterHtml);

            resourcesNode.RemoveAllChildren();

            string[] newResources = {"Wood", "Cobblestone", "Diamonds", "Gold", "Redstone", "Iron", "Coal", "Slime"};

            foreach (string currentResourceString in newResources)
            {
                HtmlNode newResourcesNode = HtmlNode.CreateNode("<div class='resource'>" + currentResourceString + "</div>");
                resourcesNode.AppendChild(newResourcesNode);
            }
            
            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}
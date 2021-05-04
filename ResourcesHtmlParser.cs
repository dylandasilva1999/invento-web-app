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

            //Basic Resources Node
            HtmlNode basicResourcesNode = htmlDoc.GetElementbyId("basicResourcesItems");

            //Rare Resources Node
            HtmlNode rareResourcesNode = htmlDoc.GetElementbyId("rareResourcesItems");

            //Food Resources Node
            HtmlNode foodResourcesNode = htmlDoc.GetElementbyId("foodResourcesItems");

            //Misc Resources Node
            HtmlNode miscResourcesNode = htmlDoc.GetElementbyId("miscResourcesItems");

            basicResourcesNode.RemoveAllChildren();
            rareResourcesNode.RemoveAllChildren();
            foodResourcesNode.RemoveAllChildren();
            miscResourcesNode.RemoveAllChildren();

            //Basic Resources Array
            string[] basicResources = {"Oak Wood", "Cobblestone", "Wool", "Sand", "Oak Planks"};

            //Rare Resources Array
            string[] rareResources = {"Diamond Ignot", "Gold Ignot", "Iron Ignot", "Coal", "Redstone Dust"};

            //Food Resources Array
            string[] foodResources = {"Wheat", "Melon", "Pumpkin", "Apple", "Carrot"};

            //Misc Resources Array
            string[] miscResources = {"Leather", "Flint", "String", "Feather", "Bones"};

            foreach (string currentBasicResourceString in basicResources)
            {
                HtmlNode newBasicResourcesNode = HtmlNode.CreateNode("<div class='basic-resource'><h1 id='basic-resource-name'>" + currentBasicResourceString + "</h1></div>");
                basicResourcesNode.AppendChild(newBasicResourcesNode);
            }

            foreach (string currentRareResourceString in rareResources)
            {
                HtmlNode newRareResourcesNode = HtmlNode.CreateNode("<div class='rare-resource'><h1 id='rare-resource-name'>" + currentRareResourceString + "</h1></div>");
                rareResourcesNode.AppendChild(newRareResourcesNode);
            }

            foreach (string currentFoodResourceString in foodResources)
            {
                HtmlNode newFoodResourcesNode = HtmlNode.CreateNode("<div class='food-resource'><h1 id='food-resource-name'>" + currentFoodResourceString + "</h1></div>");
                foodResourcesNode.AppendChild(newFoodResourcesNode);
            }

            foreach (string currentMiscResourceString in miscResources)
            {
                HtmlNode newMiscResourcesNode = HtmlNode.CreateNode("<div class='misc-resource'><h1 id='misc-resource-name'>" + currentMiscResourceString + "</h1></div>");
                miscResourcesNode.AppendChild(newMiscResourcesNode);
            }
            
            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}
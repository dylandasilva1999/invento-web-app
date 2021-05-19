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
            Basic[] basicResourcesArray = {new Wood(1), new Cobblestone(1), new Wool(1), new Sand(1), new WoodPlank(1)};

            //Rare Resources Array
            Rare[] rareResourcesArray = {new DiamondIgnot(1), new GoldIgnot(1), new IronIgnot(1), new Coal(1), new RedstoneDust(1)};

            //Food Resources Array
            Food[] foodResourcesArray = {new Wheat(1), new Melon(1), new Pumpkin(1), new Apple(1), new Carrot(1)};

            //Misc Resources Array
            Misc[] miscResourcesArray = {new Leather(1), new Flint(1), new String(1), new Feather(1), new Bones(1)};

            foreach (Basic currentBasicResource in basicResourcesArray)
            {
                HtmlNode newBasicResourcesNode = HtmlNode.CreateNode("<div class='basic-resource'><h1 id='basic-resource-name'>" + currentBasicResource.BasicBlockType + "</h1></div>");
                basicResourcesNode.AppendChild(newBasicResourcesNode);
            }

            foreach (Rare currentRareResource in rareResourcesArray)
            {
                HtmlNode newRareResourcesNode = HtmlNode.CreateNode("<div class='rare-resource'><h1 id='rare-resource-name'>" + currentRareResource.RareBlockType + "</h1></div>");
                rareResourcesNode.AppendChild(newRareResourcesNode);
            }

            foreach (Food currentFoodResource in foodResourcesArray)
            {
                HtmlNode newFoodResourcesNode = HtmlNode.CreateNode("<div class='food-resource'><h1 id='food-resource-name'>" + currentFoodResource.FoodBlockType + "</h1></div>");
                foodResourcesNode.AppendChild(newFoodResourcesNode);
            }

            foreach (Misc currentMiscResource in miscResourcesArray)
            {
                HtmlNode newMiscResourcesNode = HtmlNode.CreateNode("<div class='misc-resource'><h1 id='misc-resource-name'>" + currentMiscResource.MiscBlockType + "</h1></div>");
                miscResourcesNode.AppendChild(newMiscResourcesNode);
            }
            
            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}
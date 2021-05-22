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
            Basic[] basicResourcesArray = {new WoodResource(1), new CobblestoneResource(1), new WoolResource(1), new SandResource(1), new WoodPlankResource(1)};

            //Rare Resources Array
            Rare[] rareResourcesArray = {new DiamondIgnotResource(1), new GoldIgnotResource(1), new IronIgnotResource(1), new CoalResource(1), new RedstoneDustResource(1)};

            //Food Resources Array
            Food[] foodResourcesArray = {new WheatResource(1), new MelonSliceResource(1), new PumpkinResource(1), new AppleResource(1), new CarrotResource(1)};

            //Misc Resources Array
            Misc[] miscResourcesArray = {new LeatherResource(1), new FlintResource(1), new StringResource(1), new FeatherResource(1), new BonesResource(1)};

            foreach (Basic currentBasicResource in basicResourcesArray)
            {
                HtmlNode newBasicResourcesNode = HtmlNode.CreateNode("<div class='basic-resource'><img class='resource-image' src='" + currentBasicResource.Image + "'><h1 id='basic-resource-name'>" + currentBasicResource.BasicBlockType + "</h1></div>");
                basicResourcesNode.AppendChild(newBasicResourcesNode);
            }

            foreach (Rare currentRareResource in rareResourcesArray)
            {
                HtmlNode newRareResourcesNode = HtmlNode.CreateNode("<div class='rare-resource'><img class='resource-image' src='" + currentRareResource.Image + "'><h1 id='rare-resource-name'>" + currentRareResource.RareBlockType + "</h1></div>");
                rareResourcesNode.AppendChild(newRareResourcesNode);
            }

            foreach (Food currentFoodResource in foodResourcesArray)
            {
                HtmlNode newFoodResourcesNode = HtmlNode.CreateNode("<div class='food-resource'><img class='resource-image' src='" + currentFoodResource.Image + "'><h1 id='food-resource-name'>" + currentFoodResource.FoodBlockType + "</h1></div>");
                foodResourcesNode.AppendChild(newFoodResourcesNode);
            }

            foreach (Misc currentMiscResource in miscResourcesArray)
            {
                HtmlNode newMiscResourcesNode = HtmlNode.CreateNode("<div class='misc-resource'><img class='resource-image' src='" + currentMiscResource.Image + "'><h1 id='misc-resource-name'>" + currentMiscResource.MiscBlockType + "</h1></div>");
                miscResourcesNode.AppendChild(newMiscResourcesNode);
            }
            
            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}
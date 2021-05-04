using System;
using System.Text;
using System.IO;
using HtmlAgilityPack;

namespace invento_web_app
{
    class InventoryHtmlParser
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

            HtmlNode inventoryNode = htmlDoc.GetElementbyId("inventoryItems");
            HtmlNode recipeNode = htmlDoc.GetElementbyId("recipeItems");

            inventoryNode.RemoveAllChildren();
            recipeNode.RemoveAllChildren();

            string[] newInventoryItem = {"Wood", "Cobblestone", "Diamonds", "Gold", "Redstone", "Iron", "Coal", "Slime"};
            string[] newRecipe = {"Pick Axe", "Torch", "Shovel", "Boat", "Diamond Pick Axe", "Iron Sword", "Repeater", "Stone"};

            foreach (string currentInventoryString in newInventoryItem)
            {
                HtmlNode newInventoryNode = HtmlNode.CreateNode("<div class='inventory-item'><h1 id='inv-item-name'>" + currentInventoryString + "</h1></div>");
                inventoryNode.AppendChild(newInventoryNode);
            }

            foreach (string currentRecipeString in newRecipe)
            {
                HtmlNode newRecipeNode = HtmlNode.CreateNode("<div class='recipe-item'><h1 id='recipe-name'>" + currentRecipeString + "</h1></div>");
                recipeNode.AppendChild(newRecipeNode);
            }

            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}
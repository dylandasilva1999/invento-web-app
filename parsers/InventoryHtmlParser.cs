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

            //GET INVENTORY LIST FROM FRONTEND
            HtmlNode inventoryNode = htmlDoc.GetElementbyId("inventoryItems");
            //GET RECIPES LIST FROM FRONTEND
            HtmlNode recipeNode = htmlDoc.GetElementbyId("recipeItems");

            string[] newRecipe = {"Pick Axe", "Torch", "Shovel", "Boat", "Diamond Pick Axe", "Iron Sword", "Repeater", "Stone"};

            //REMOVE ALL CHILDREN FROM INVENTORY LIST
            inventoryNode.RemoveAllChildren();
            //REMOVE ALL CHILDREN FROM RECIPES LIST
            recipeNode.RemoveAllChildren();

            // CREATE A NEW INSTANCE OF INVENTORY
            Inventory inventory = new Inventory();

            //SHOW INVENTORY ITEMS TO FRONTEND
            foreach (Item item in inventory.Items)
            {
                HtmlNode newInventoryNode = HtmlNode.CreateNode("<div class='inventory-item'><img class='item-image' src='" + item.Image + "'><h1 id='inv-item-name'>" + item.BlockType + "</h1><div class='number'><span class='minus'>-</span><input type='text' value='" + item.Count + "'/><span class='plus'>+</span></div></div>");
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
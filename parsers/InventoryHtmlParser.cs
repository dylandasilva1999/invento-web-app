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

            //SHOW INVENTORY ITEMS TO FRONTEND
            foreach (Item curItem in Inventory.Items)
            {
                HtmlNode newInventoryNode = HtmlNode.CreateNode("<div class='inventory-item'><img class='item-image' src='" 
                + curItem.Image + "'><h1 id='inv-item-name'>" + curItem.BlockType + "</h1><div class='number'><span class='minus'>-</span><input type='text' name='" + curItem.BlockType + "' value='" 
                + curItem.Count + "'/><span class='plus'>+</span></div</div><input class='update-btn' type='submit' value='Update'>");
                inventoryNode.AppendChild(newInventoryNode);
            }

            foreach (Recipe curRecipe in RecipeBook.Recipes)
            {
                HtmlNode newRecipeNode = HtmlNode.CreateNode("<div class='recipe-item'><img class='item-image' src='" 
                + curRecipe.Result.Image + "'><h1 id='recipe-name'>" + curRecipe.Result.BlockType + "</h1><div class='number'><span class='minus'>-</span><input type='text' name='" + curRecipe.Result.BlockType + "' value='" 
                + curRecipe.Result.Count + "'/><span class='plus'>+</span></div><input class='craft-btn' type='submit' value='Craft'>");
                recipeNode.AppendChild(newRecipeNode);
            }

            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}
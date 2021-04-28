using System;
using System.Text;
using System.IO;
using HtmlAgilityPack;

namespace invento_web_app
{
    class RecipesHtmlParser
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

            HtmlNode recipesNode = htmlDoc.GetElementbyId("recipesItems");

            recipesNode.RemoveAllChildren();

            string[] newRecipes = {"Pick Axe", "Smooth Stone", "Torch", "Golden Apple", "Repeater", "Iron Sword", "Diamond Chestplate", "Slime Block"};

            foreach (string currentRecipeString in newRecipes)
            {
                HtmlNode newRecipesNode = HtmlNode.CreateNode("<div class='recipe'>" + currentRecipeString + "</div>");
                recipesNode.AppendChild(newRecipesNode);
            }

            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}
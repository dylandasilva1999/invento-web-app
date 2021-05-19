using System;
using System.Collections;

namespace invento_web_app
{
    class RecipeBook
    {
        private static ArrayList recipes = new ArrayList();
        public static void Populate()
        {
             //Stick recipe
            Recipe stickRecipe = new Recipe((Craft) Stick.Get(), new Item[3,3] {{WoodPlank.Get(), WoodPlank.Get(), null}, 
                                                                {WoodPlank.Get(), Stick.Get(), null},
                                                                {null, Stick.Get(), null}});
            recipes.Add(stickRecipe);
        } 

        public static ArrayList Recipes
        {
            get{
                return recipes;
            }
        }
    }
}
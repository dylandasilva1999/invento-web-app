using System;
using System.Collections;

namespace invento_web_app
{
    class RecipeBook
    {
        private static ArrayList recipes = new ArrayList();

        public static void Populate()
        {

        }

        public static ArrayList Recipes
        {
            get{
                return recipes;
            }
        }
    }
}
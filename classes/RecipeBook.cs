using System;
using System.Collections;

namespace invento_web_app
{
    class RecipeBook
    {
        private static ArrayList recipes = new ArrayList();
        public static void Populate()
        {
            ArrayList records = Database.ReadRecipes();

            foreach (Tuple<string, string[,]> curTuple in records)
            {
                 Recipe curRecipe = new Recipe((Craft) Inventory.GetClass(curTuple.Item1), new Item[3,3]
                     {{Inventory.GetClass(curTuple.Item2[0,0]),Inventory.GetClass(curTuple.Item2[0,1]),Inventory.GetClass(curTuple.Item2[0,2])},
                     {Inventory.GetClass(curTuple.Item2[1,0]),Inventory.GetClass(curTuple.Item2[1,1]),Inventory.GetClass(curTuple.Item2[1,2])},
                     {Inventory.GetClass(curTuple.Item2[2,0]),Inventory.GetClass(curTuple.Item2[2,1]),Inventory.GetClass(curTuple.Item2[2,2])}});

                 recipes.Add(curRecipe);
            }
        } 

        public static ArrayList Recipes
        {
            get
            {
                return recipes;
            }
        }

        public static void AddRecipe(Recipe recipe)
        {
            string blockType = recipe.Result.BlockType;

            bool newRecipe = true;
            foreach(Recipe curRecipe in recipes)
            {
                if(curRecipe.Result.BlockType == blockType)
                {
                    newRecipe = false;
                }
            }

            if(newRecipe == true)
            {
                recipes.Add(recipe);
                Database.AddRecipe(recipe);
            }
        }

		public static void ApplyRecipe(string blockType) 
		{
			Recipe selectedRecipe = null;
			foreach (Recipe curRecipe in recipes)
			{
				if(curRecipe.Result.BlockType == blockType)
				{
					selectedRecipe = curRecipe;
				}
			}

			if(selectedRecipe.IsViable())
			{
				selectedRecipe.Result.Count++;
				foreach (Item curInput in selectedRecipe.Inputs)
				{
					if(curInput != null)
					{
						curInput.Count--;
					}
				}
			}
		}
    }
}
using System;

namespace invento_web_app
{
    class StoneAxe: Basic, Craft
    {
        private Recipe recipe;

        public StoneAxe(int newCount): base(newCount)
        {
            basicBlockType = "Stone Axe";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Axe has been placed");
        }

        public Recipe GetRecipe()
        {
            return recipe;
        }

        public void SetRecipe(Recipe newRecipe)
        {
            recipe = newRecipe;
        }
    }
}
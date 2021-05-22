using System;

namespace invento_web_app
{
    class WoodAxe: Basic, Craft
    {
        private Recipe recipe;

        public WoodAxe(int newCount): base(newCount)
        {
            basicBlockType = "Wood Axe";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Axe has been placed");
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
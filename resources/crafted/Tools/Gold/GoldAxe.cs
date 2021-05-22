using System;

namespace invento_web_app
{
    class GoldAxe: Basic, Craft
    {
        private Recipe recipe;

        public GoldAxe(int newCount): base(newCount)
        {
            basicBlockType = "Gold Axe";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Axe has been placed");
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
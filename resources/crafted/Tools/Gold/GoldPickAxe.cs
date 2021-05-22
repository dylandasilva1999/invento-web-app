using System;

namespace invento_web_app
{
    class GoldPickAxe: Basic, Craft
    {
        private Recipe recipe;

        public GoldPickAxe(int newCount): base(newCount)
        {
            basicBlockType = "Gold Pick Axe";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Pick Axe has been placed");
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
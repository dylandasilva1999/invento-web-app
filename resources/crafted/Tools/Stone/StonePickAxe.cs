using System;

namespace invento_web_app
{
    class StonePickAxe: Basic, Craft
    {
        private Recipe recipe;

        public StonePickAxe(int newCount): base(newCount)
        {
            basicBlockType = "Stone Pick Axe";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Sword has been placed");
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
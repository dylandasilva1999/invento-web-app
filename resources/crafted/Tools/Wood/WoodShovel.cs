using System;

namespace invento_web_app
{
    class WoodShovel: Basic, Craft
    {
        private Recipe recipe;

        public WoodShovel(int newCount): base(newCount)
        {
            basicBlockType = "Wood Shovel";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Shovel has been placed");
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
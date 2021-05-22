using System;

namespace invento_web_app
{
    class StoneShovel: Basic, Craft
    {
        private Recipe recipe;

        public StoneShovel(int newCount): base(newCount)
        {
            basicBlockType = "Stone Shovel";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Shovel has been placed");
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
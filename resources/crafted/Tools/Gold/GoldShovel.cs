using System;

namespace invento_web_app
{
    class GoldShovel: Basic, Craft
    {
        private Recipe recipe;

        public GoldShovel(int newCount): base(newCount)
        {
            basicBlockType = "Gold Shovel";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Shovel has been placed");
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
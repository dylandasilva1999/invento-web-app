using System;

namespace invento_web_app
{
    class DiamondShovel: Basic, Craft
    {
        private Recipe recipe;

        public DiamondShovel(int newCount): base(newCount)
        {
            basicBlockType = "Diamond Shovel";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Shovel has been placed");
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
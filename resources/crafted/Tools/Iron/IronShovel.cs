using System;

namespace invento_web_app
{
    class IronShovel: Basic, Craft
    {
        private Recipe recipe;

        public IronShovel(int newCount): base(newCount)
        {
            basicBlockType = "Iron Shovel";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Shovel has been placed");
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
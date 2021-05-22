using System;

namespace invento_web_app
{
    class IronAxe: Basic, Craft
    {
        private Recipe recipe;

        public IronAxe(int newCount): base(newCount)
        {
            basicBlockType = "Iron Axe";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Axe has been placed");
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
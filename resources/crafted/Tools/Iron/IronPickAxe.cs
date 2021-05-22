using System;

namespace invento_web_app
{
    class IronPickAxe: Basic, Craft
    {
        private Recipe recipe;

        public IronPickAxe(int newCount): base(newCount)
        {
            basicBlockType = "Iron Pick Axe";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Pick Axe has been placed");
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
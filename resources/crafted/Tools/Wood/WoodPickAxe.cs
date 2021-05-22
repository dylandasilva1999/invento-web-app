using System;

namespace invento_web_app
{
    class WoodPickAxe: Basic, Craft
    {
        private Recipe recipe;

        public WoodPickAxe(int newCount): base(newCount)
        {
            basicBlockType = "Wood Pick Axe";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Pick Axe has been placed");
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
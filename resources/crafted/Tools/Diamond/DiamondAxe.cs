using System;

namespace invento_web_app
{
    class DiamondAxe: Basic, Craft
    {
        private Recipe recipe;

        public DiamondAxe(int newCount): base(newCount)
        {
            basicBlockType = "Diamond Axe";
            classType = this;
            image = "";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Axe has been placed");
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
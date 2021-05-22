using System;

namespace invento_web_app
{
    class DiamondPickAxe: Basic, Craft
    {
        private Recipe recipe;

        public DiamondPickAxe(int newCount): base(newCount)
        {
            basicBlockType = "Diamond Pick Axe";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Pick Axe has been placed");
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
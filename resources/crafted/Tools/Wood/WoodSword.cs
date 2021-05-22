using System;

namespace invento_web_app
{
    class WoodSword: Basic, Craft
    {
        private Recipe recipe;

        public WoodSword(int newCount): base(newCount)
        {
            basicBlockType = "Wood Sword";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Sword has been placed");
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
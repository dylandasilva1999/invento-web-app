using System;

namespace invento_web_app
{
    class StoneSword: Basic, Craft
    {
        private Recipe recipe;

        public StoneSword(int newCount): base(newCount)
        {
            basicBlockType = "Stone Sword";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Sword has been placed");
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
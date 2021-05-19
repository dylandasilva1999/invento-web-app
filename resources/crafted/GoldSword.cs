using System;

namespace invento_web_app
{
    class GoldSword: Basic, Craft
    {
        private Recipe recipe;

        public GoldSword(int newCount): base(newCount)
        {
            basicBlockType = "Gold Sword";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Sword has been placed");
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
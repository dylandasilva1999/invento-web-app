using System;

namespace invento_web_app
{
    class IronSword: Basic, Craft
    {
        private Recipe recipe;

        public IronSword(int newCount): base(newCount)
        {
            basicBlockType = "Iron Sword";
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
using System;

namespace invento_web_app
{
    class GoldenApple: Item, Craft
    {
        private Recipe recipe;

        public GoldenApple(int newCount): base(newCount)
        {
            blockType = "Golden Apple";
            classType = this;
            image = "img/images/crafted/items/golden_apple.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Golden Apple has been placed");
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
using System;

namespace invento_web_app
{
    class Arrow: Item, Craft
    {
        private Recipe recipe;

        public Arrow(int newCount): base(newCount)
        {
            blockType = "Arrow";
            classType = this;
            image = "img/images/crafted/items/arrow.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Arrow has been placed");
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
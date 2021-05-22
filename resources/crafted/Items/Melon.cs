using System;

namespace invento_web_app
{
    class Melon: Item, Craft
    {
        private Recipe recipe;

        public Melon(int newCount): base(newCount)
        {
            blockType = "Melon";
            classType = this;
            image = "img/images/crafted/items/melon.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Melon has been placed");
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
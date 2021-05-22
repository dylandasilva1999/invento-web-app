using System;

namespace invento_web_app
{
    class Painting: Item, Craft
    {
        private Recipe recipe;

        public Painting(int newCount): base(newCount)
        {
            blockType = "Painting";
            classType = this;
            image = "img/images/crafted/items/painting.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Painting has been placed");
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
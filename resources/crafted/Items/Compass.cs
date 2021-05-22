using System;

namespace invento_web_app
{
    class Compass: Item, Craft
    {
        private Recipe recipe;

        public Compass(int newCount): base(newCount)
        {
            blockType = "Compass";
            classType = this;
            image = "img/images/crafted/items/compass.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Compass has been placed");
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
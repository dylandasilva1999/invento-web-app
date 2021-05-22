using System;

namespace invento_web_app
{
    class Flint: Item, Craft
    {
        private Recipe recipe;

        public Flint(int newCount): base(newCount)
        {
            blockType = "Flint";
            classType = this;
            image = "img/images/misc/flint.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Flint has been placed");
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
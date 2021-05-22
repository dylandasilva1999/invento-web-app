using System;

namespace invento_web_app
{
    class Bed: Item, Craft
    {
        private Recipe recipe;

        public Bed(int newCount): base(newCount)
        {
            blockType = "Bed";
            classType = this;
            image = "img/images/crafted/items/bed.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Bed has been placed");
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
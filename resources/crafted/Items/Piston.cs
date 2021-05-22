using System;

namespace invento_web_app
{
    class Piston: Item, Craft
    {
        private Recipe recipe;

        public Piston(int newCount): base(newCount)
        {
            blockType = "Piston";
            classType = this;
            image = "img/images/crafted/items/piston.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Piston has been placed");
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
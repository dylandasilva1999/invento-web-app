using System;

namespace invento_web_app
{
    class Stick: Item, Craft
    {
        private Recipe recipe;

        public Stick(int newCount): base(newCount)
        {
            blockType = "Stick";
            classType = this;
            image = "img/images/crafted/items/stick.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stick has been placed");
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
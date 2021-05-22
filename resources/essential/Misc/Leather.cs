using System;

namespace invento_web_app
{
    class Leather: Item, Craft
    {
        private Recipe recipe;

        public Leather(int newCount): base(newCount)
        {
            blockType = "Leather";
            classType = this;
            image = "img/images/misc/leather.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Leather has been placed");
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
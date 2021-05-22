using System;

namespace invento_web_app
{
    class Wheat: Item, Craft
    {
        private Recipe recipe;

        public Wheat(int newCount): base(newCount)
        {
            blockType = "Wheat";
            classType = this;
            image = "img/images/food/wheat.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wheat has been placed");
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
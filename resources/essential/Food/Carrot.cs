using System;

namespace invento_web_app
{
    class Carrot: Item, Craft
    {
        private Recipe recipe;

        public Carrot(int newCount): base(newCount)
        {
            blockType = "Carrot";
            classType = this;
            image = "img/images/food/carrot.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Carrot has been placed");
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
using System;

namespace invento_web_app
{
    class Pumpkin: Item, Craft
    {
        private Recipe recipe;

        public Pumpkin(int newCount): base(newCount)
        {
            blockType = "Pumpkin";
            classType = this;
            image = "img/images/food/pumpkin.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Pumpkin has been placed");
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
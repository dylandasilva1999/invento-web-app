using System;

namespace invento_web_app
{
    class Sand: Item, Craft
    {
        private Recipe recipe;

        public Sand(int newCount): base(newCount)
        {
            blockType = "Sand";
            classType = this;
            image = "img/images/basic/sand.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Sand has been placed");
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
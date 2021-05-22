using System;

namespace invento_web_app
{
    class HayBale: Item, Craft
    {
        private Recipe recipe;

        public HayBale(int newCount): base(newCount)
        {
            blockType = "HayBale";
            classType = this;
            image = "img/images/crafted/items/hay_bale.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("HayBale has been placed");
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
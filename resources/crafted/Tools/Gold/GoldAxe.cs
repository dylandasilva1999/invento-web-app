using System;

namespace invento_web_app
{
    class GoldAxe: Item, Craft
    {
        private Recipe recipe;

        public GoldAxe(int newCount): base(newCount)
        {
            blockType = "Gold Axe";
            classType = this;
            image = "img/images/crafted/tools/gold/gold_axe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Axe has been placed");
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
using System;

namespace invento_web_app
{
    class GoldPickAxe: Item, Craft
    {
        private Recipe recipe;

        public GoldPickAxe(int newCount): base(newCount)
        {
            blockType = "Gold Pick Axe";
            classType = this;
            image = "img/images/crafted/tools/diamond/gold_pick_axe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Pick Axe has been placed");
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
using System;

namespace invento_web_app
{
    class WoodAxe: Item, Craft
    {
        private Recipe recipe;

        public WoodAxe(int newCount): base(newCount)
        {
            blockType = "Wood Axe";
            classType = this;
            image = "img/images/crafted/tools/diamond/wood_axe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Axe has been placed");
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
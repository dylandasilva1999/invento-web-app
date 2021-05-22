using System;

namespace invento_web_app
{
    class DiamondPickAxe: Item, Craft
    {
        private Recipe recipe;

        public DiamondPickAxe(int newCount): base(newCount)
        {
            blockType = "Diamond Pick Axe";
            classType = this;
            image = "img/images/crafted/tools/diamond/diamond_pick_axe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Pick Axe has been placed");
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
using System;

namespace invento_web_app
{
    class WoodPickAxe: Item, Craft
    {
        private Recipe recipe;

        public WoodPickAxe(int newCount): base(newCount)
        {
            blockType = "Wood Pick Axe";
            classType = this;
            image = "img/images/crafted/tools/wood/wood_pick_axe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Pick Axe has been placed");
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
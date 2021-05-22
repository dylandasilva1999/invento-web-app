using System;

namespace invento_web_app
{
    class StonePickAxe: Item, Craft
    {
        private Recipe recipe;

        public StonePickAxe(int newCount): base(newCount)
        {
            blockType = "Stone Pick Axe";
            classType = this;
            image = "img/images/crafted/tools/diamond/stone_pick_axe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Sword has been placed");
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
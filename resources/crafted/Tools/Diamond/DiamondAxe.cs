using System;

namespace invento_web_app
{
    class DiamondAxe: Item, Craft
    {
        private Recipe recipe;

        public DiamondAxe(int newCount): base(newCount)
        {
            blockType = "Diamond Axe";
            classType = this;
            image = "img/images/crafted/tools/diamond/diamond_axe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Axe has been placed");
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
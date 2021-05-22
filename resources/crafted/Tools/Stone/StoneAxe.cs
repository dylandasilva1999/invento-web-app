using System;

namespace invento_web_app
{
    class StoneAxe: Item, Craft
    {
        private Recipe recipe;

        public StoneAxe(int newCount): base(newCount)
        {
            blockType = "Stone Axe";
            classType = this;
            image = "img/images/crafted/tools/diamond/stone_axe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Axe has been placed");
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
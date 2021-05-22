using System;

namespace invento_web_app
{
    class IronAxe: Item, Craft
    {
        private Recipe recipe;

        public IronAxe(int newCount): base(newCount)
        {
            blockType = "Iron Axe";
            classType = this;
            image = "img/images/crafted/tools/diamond/iron_axe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Axe has been placed");
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
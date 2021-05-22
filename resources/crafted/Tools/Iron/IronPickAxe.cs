using System;

namespace invento_web_app
{
    class IronPickAxe: Item, Craft
    {
        private Recipe recipe;

        public IronPickAxe(int newCount): base(newCount)
        {
            blockType = "Iron Pick Axe";
            classType = this;
            image = "img/images/crafted/tools/diamond/iron_pick_axe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Pick Axe has been placed");
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
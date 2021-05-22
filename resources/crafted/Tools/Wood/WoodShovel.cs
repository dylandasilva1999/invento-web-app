using System;

namespace invento_web_app
{
    class WoodShovel: Item, Craft
    {
        private Recipe recipe;

        public WoodShovel(int newCount): base(newCount)
        {
            blockType = "Wood Shovel";
            classType = this;
            image = "img/images/crafted/tools/diamond/wood_shovel.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Shovel has been placed");
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
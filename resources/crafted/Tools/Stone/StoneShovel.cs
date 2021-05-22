using System;

namespace invento_web_app
{
    class StoneShovel: Item, Craft
    {
        private Recipe recipe;

        public StoneShovel(int newCount): base(newCount)
        {
            blockType = "Stone Shovel";
            classType = this;
            image = "img/images/crafted/tools/stone/stone_shovel.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Shovel has been placed");
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
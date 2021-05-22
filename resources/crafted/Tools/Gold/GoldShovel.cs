using System;

namespace invento_web_app
{
    class GoldShovel: Item, Craft
    {
        private Recipe recipe;

        public GoldShovel(int newCount): base(newCount)
        {
            blockType = "Gold Shovel";
            classType = this;
            image = "img/images/crafted/tools/diamond/gold_shovel.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Shovel has been placed");
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
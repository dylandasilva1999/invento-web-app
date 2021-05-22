using System;

namespace invento_web_app
{
    class DiamondShovel: Item, Craft
    {
        private Recipe recipe;

        public DiamondShovel(int newCount): base(newCount)
        {
            blockType = "Diamond Shovel";
            classType = this;
            image = "img/images/crafted/tools/diamond/diamond_shovel.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Shovel has been placed");
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
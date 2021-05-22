using System;

namespace invento_web_app
{
    class IronShovel: Item, Craft
    {
        private Recipe recipe;

        public IronShovel(int newCount): base(newCount)
        {
            blockType = "Iron Shovel";
            classType = this;
            image = "img/images/crafted/tools/diamond/iron_shovel.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Shovel has been placed");
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
using System;

namespace invento_web_app
{
    class IronSword: Item, Craft
    {
        private Recipe recipe;

        public IronSword(int newCount): base(newCount)
        {
            blockType = "Iron Sword";
            classType = this;
            image = "img/images/crafted/tools/diamond/iron_sword.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Sword has been placed");
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
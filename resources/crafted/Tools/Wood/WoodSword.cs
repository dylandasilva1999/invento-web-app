using System;

namespace invento_web_app
{
    class WoodSword: Item, Craft
    {
        private Recipe recipe;

        public WoodSword(int newCount): base(newCount)
        {
            blockType = "Wood Sword";
            classType = this;
            image = "img/images/crafted/tools/diamond/wood_sword.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Sword has been placed");
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
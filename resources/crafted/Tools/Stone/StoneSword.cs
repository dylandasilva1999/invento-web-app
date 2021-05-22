using System;

namespace invento_web_app
{
    class StoneSword: Item, Craft
    {
        private Recipe recipe;

        public StoneSword(int newCount): base(newCount)
        {
            blockType = "Stone Sword";
            classType = this;
            image = "img/images/crafted/tools/stone/stone_sword.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Sword has been placed");
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
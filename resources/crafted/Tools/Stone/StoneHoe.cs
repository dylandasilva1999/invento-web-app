using System;

namespace invento_web_app
{
    class StoneHoe: Item, Craft
    {
        private Recipe recipe;

        public StoneHoe(int newCount): base(newCount)
        {
            blockType = "Stone Hoe";
            classType = this;
            image = "img/images/crafted/tools/stone/stone_hoe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stone Hoe has been placed");
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
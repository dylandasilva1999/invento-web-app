using System;

namespace invento_web_app
{
    class WoodHoe: Item, Craft
    {
        private Recipe recipe;

        public WoodHoe(int newCount): base(newCount)
        {
            blockType = "Wood Hoe";
            classType = this;
            image = "img/images/crafted/tools/wood/wood_hoe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Hoe has been placed");
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
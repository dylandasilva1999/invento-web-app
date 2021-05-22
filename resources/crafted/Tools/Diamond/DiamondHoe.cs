using System;

namespace invento_web_app
{
    class DiamondHoe: Item, Craft
    {
        private Recipe recipe;

        public DiamondHoe(int newCount): base(newCount)
        {
            blockType = "Diamond Hoe";
            classType = this;
            image = "img/images/crafted/tools/diamond/diamond_hoe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Hoe has been placed");
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
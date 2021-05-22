using System;

namespace invento_web_app
{
    class GlassBlock: Item, Craft
    {
        private Recipe recipe;

        public GlassBlock(int newCount): base(newCount)
        {
            blockType = "Glass Block";
            classType = this;
            image = "img/images/crafted/items/glass_block.png"; 
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Glass Block has been placed");
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
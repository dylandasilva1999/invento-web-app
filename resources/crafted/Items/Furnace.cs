using System;

namespace invento_web_app
{
    class FurnaceItem: Item, Craft
    {
        private Recipe recipe;

        public FurnaceItem(int newCount): base(newCount)
        {
            blockType = "Furnace";
            classType = this;
            image = "img/images/crafted/items/furnace.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Furnace has been placed");
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
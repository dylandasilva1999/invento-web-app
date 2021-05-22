using System;

namespace invento_web_app
{
    class ItemFrame: Item, Craft
    {
        private Recipe recipe;

        public ItemFrame(int newCount): base(newCount)
        {
            blockType = "Item Frame";
            classType = this;
            image = "img/images/crafted/items/item_frame.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Item Frame has been placed");
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
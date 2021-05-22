using System;

namespace invento_web_app
{
    class CraftTable: Item, Craft
    {
        private Recipe recipe;

        public CraftTable(int newCount): base(newCount)
        {
            blockType = "Crafting Table";
            classType = this;
            image = "img/images/crafted/items/craft_table.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Crafting Table has been placed");
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
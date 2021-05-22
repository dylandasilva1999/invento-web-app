using System;

namespace invento_web_app
{
    class FletchingTable: Item, Craft
    {
        private Recipe recipe;

        public FletchingTable(int newCount): base(newCount)
        {
            blockType = "Fletching Table";
            classType = this;
            image = "img/images/crafted/items/fletching_table.png";   
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Fletching Table has been placed");
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
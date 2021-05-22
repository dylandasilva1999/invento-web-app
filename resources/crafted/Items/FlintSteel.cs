using System;

namespace invento_web_app
{
    class FlintSteel: Item, Craft
    {
        private Recipe recipe;

        public FlintSteel(int newCount): base(newCount)
        {
            blockType = "Flint and Steel";
            classType = this;
            image = "img/images/crafted/items/flint_steel.png";    
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Flint and Steel has been placed");
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
using System;

namespace invento_web_app
{
    class Bread: Item, Craft
    {
        private Recipe recipe;

        public Bread(int newCount): base(newCount)
        {
            blockType = "Bread";
            classType = this;
            image = "img/images/crafted/items/bread.png";    
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Bread has been placed");
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
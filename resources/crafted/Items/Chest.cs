using System;

namespace invento_web_app
{
    class Chest: Item, Craft
    {
        private Recipe recipe;

        public Chest(int newCount): base(newCount)
        {
            blockType = "Chest";
            classType = this;
            image = "img/images/crafted/items/chest.png";  
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Chest has been placed");
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
using System;

namespace invento_web_app
{
    class Bow: Item, Craft
    {
        private Recipe recipe;

        public Bow(int newCount): base(newCount)
        {
            blockType = "Bow";
            classType = this;
            image = "img/images/crafted/items/bow.png"; 
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Bow has been placed");
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
using System;

namespace invento_web_app
{
    class Door: Item, Craft
    {
        private Recipe recipe;

        public Door(int newCount): base(newCount)
        {
            blockType = "Door";
            classType = this;
            image = "img/images/crafted/items/door.png";   
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Door has been placed");
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
using System;

namespace invento_web_app
{
    class Cobblestone: Item, Craft
    {
        private Recipe recipe;

        public Cobblestone(int newCount): base(newCount)
        {
            blockType = "Cobblestone";
            classType = this;
            image = "img/images/basic/cobblestone.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Cobblestone has been placed");
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
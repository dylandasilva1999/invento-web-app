using System;

namespace invento_web_app
{
    class Feather: Item, Craft
    {
        private Recipe recipe;

        public Feather(int newCount): base(newCount)
        {
            blockType = "Feather";
            classType = this;
            image = "img/images/misc/feather.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Feather has been placed");
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
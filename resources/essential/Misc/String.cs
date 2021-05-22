using System;

namespace invento_web_app
{
    class String: Item, Craft
    {
        private Recipe recipe;

        public String(int newCount): base(newCount)
        {
            blockType = "String";
            classType = this;
            image = "img/images/misc/string.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("String has been placed");
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
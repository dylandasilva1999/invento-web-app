using System;

namespace invento_web_app
{
    class Apple: Item
    {
        private Recipe recipe;

        public Apple(int newCount): base(newCount)
        {
            blockType = "Apple";
            classType = this;
            image = "img/images/food/apple.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Apple has been placed");
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
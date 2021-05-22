using System;

namespace invento_web_app
{
    class Coal: Item, Craft
    {
        private Recipe recipe;

        public Coal(int newCount): base(newCount)
        {
            blockType = "Coal";
            classType = this;
            image = "img/images/rare/coal.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Coal has been placed");
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
using System;

namespace invento_web_app
{
    class GoldIgnot: Item, Craft
    {
        private Recipe recipe;

        public GoldIgnot(int newCount): base(newCount)
        {
            blockType = "Gold Ignot";
            classType = this;
            image = "img/images/rare/gold.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Ignot has been placed");
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
using System;

namespace invento_web_app
{
    class RedstoneDust: Item, Craft
    {
        private Recipe recipe;

        public RedstoneDust(int newCount): base(newCount)
        {
            blockType = "Redstone Dust";
            classType = this;
            image = "img/images/rare/redstone.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Redstone Dust has been placed");
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
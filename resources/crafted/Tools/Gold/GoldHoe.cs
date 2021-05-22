using System;

namespace invento_web_app
{
    class GoldHoe: Item, Craft
    {
        private Recipe recipe;

        public GoldHoe(int newCount): base(newCount)
        {
            blockType = "Gold Hoe";
            classType = this;
            image = "img/images/crafted/tools/gold/gold_hoe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Gold Hoe has been placed");
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
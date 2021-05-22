using System;

namespace invento_web_app
{
    class GoldSword: Item, Craft
    {
        private Recipe recipe;

        public GoldSword(int newCount): base(newCount)
        {
            blockType = "Gold Sword";
            classType = this;
            image = "img/images/crafted/tools/diamond/gold_sword.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Sword has been placed");
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
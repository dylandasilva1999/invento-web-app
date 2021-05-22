using System;

namespace invento_web_app
{
    class DiamondSword: Item, Craft
    {
        private Recipe recipe;

        public DiamondSword(int newCount): base(newCount)
        {
            blockType = "Diamond Sword";
            classType = this;
            image = "img/images/crafted/tools/diamond/diamond_sword.png";
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
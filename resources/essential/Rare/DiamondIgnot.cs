using System;

namespace invento_web_app
{
    class DiamondIgnot: Item, Craft
    {
        private Recipe recipe;

        public DiamondIgnot(int newCount): base(newCount)
        {
            blockType = "Diamond Ignot";
            classType = this;
            image = "img/images/rare/diamond.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Diamond Ignot has been placed");
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
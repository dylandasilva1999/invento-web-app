using System;

namespace invento_web_app
{
    class WoodPlank: Item, Craft
    {
        private Recipe recipe;

        public WoodPlank(int newCount): base(newCount)
        {
            blockType = "Wood Plank";
            classType = this;
            image = "img/images/basic/plank.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Plank has been placed");
        }
        public void Burn()
        {
            Console.WriteLine("Wood Plank is burning");
        }
        public void Melt()
        {
            Console.WriteLine("Wood Plank is melting");
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
using System;

namespace invento_web_app
{
    class WoodLog: Item, Craft
    {
        private Recipe recipe;

        public WoodLog(int newCount): base(newCount)
        {
            blockType = "Wood Log";
            classType = this;
            image = "img/images/basic/log.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Log has been placed");
        }
        public void Burn()
        {
            Console.WriteLine("Wood Log is burning");
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
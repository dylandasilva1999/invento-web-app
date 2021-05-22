using System;

namespace invento_web_app
{
    class Wool: Basic, Flammable
    {
        private Recipe recipe;

        public Wool(int newCount): base(newCount)
        {
            blockType = "Wool";
            classType = this;
            image = "img/images/basic/wool.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wool has been placed");
        }

        public void Burn()
        {
            Console.WriteLine("Wool is burning");
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
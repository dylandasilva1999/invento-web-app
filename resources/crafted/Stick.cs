using System;

namespace invento_web_app
{
    class Stick: Basic, Craft
    {
        private Recipe recipe;

        public Stick(int newCount): base(newCount)
        {
            basicBlockType = "Stick material";
            classType = this;
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Stick has been placed");
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
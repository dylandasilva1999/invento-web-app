using System;

namespace invento_web_app
{
    class Ladder: Item, Craft
    {
        private Recipe recipe;

        public Ladder(int newCount): base(newCount)
        {
            blockType = "Ladder";
            classType = this;
            image = "img/images/crafted/items/ladder.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Ladder has been placed");
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
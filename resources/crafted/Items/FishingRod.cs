using System;

namespace invento_web_app
{
    class FishingRod: Item, Craft
    {
        private Recipe recipe;

        public FishingRod(int newCount): base(newCount)
        {
            blockType = "FishingRod";
            classType = this;
            image = "img/images/crafted/items/fishing_rod.png";   
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("FishingRod has been placed");
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
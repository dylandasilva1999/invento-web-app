using System;

namespace invento_web_app
{
    class Torch: Item, Craft
    {
        private Recipe recipe;

        public Torch(int newCount): base(newCount)
        {
            blockType = "Torch";
            classType = this;
            image = "img/images/crafted/items/torch.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Torch has been placed");
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
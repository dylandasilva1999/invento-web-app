using System;

namespace invento_web_app
{
    class RedstoneTorch: Item, Craft
    {
        private Recipe recipe;

        public RedstoneTorch(int newCount): base(newCount)
        {
            blockType = "Redstone Torch";
            classType = this;
            image = "img/images/crafted/items/redstone_torch.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Redstone Torch has been placed");
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
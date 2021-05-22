using System;

namespace invento_web_app
{
    class MelonSlice: Item, Craft
    {
        private Recipe recipe;

        public MelonSlice(int newCount): base(newCount)
        {
            blockType = "Melon Slice";
            classType = this;
            image = "img/images/food/melon_slice.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Melon Slice has been placed");
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
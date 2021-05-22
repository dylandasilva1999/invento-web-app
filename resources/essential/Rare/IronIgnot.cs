using System;

namespace invento_web_app
{
    class IronIgnot: Item, Craft
    {
        private Recipe recipe;

        public IronIgnot(int newCount): base(newCount)
        {
            blockType = "Iron Ignot";
            classType = this;
            image = "img/images/rare/iron.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Ignot has been placed");
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
using System;

namespace invento_web_app
{
    class IronHoe: Item, Craft
    {
        private Recipe recipe;

        public IronHoe(int newCount): base(newCount)
        {
            blockType = "Iron Hoe";
            classType = this;
            image = "img/images/crafted/tools/diamond/iron_hoe.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Iron Hoe has been placed");
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
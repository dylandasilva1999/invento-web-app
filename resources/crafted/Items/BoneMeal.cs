using System;

namespace invento_web_app
{
    class BoneMeal: Item, Craft
    {
        private Recipe recipe;

        public BoneMeal(int newCount): base(newCount)
        {
            blockType = "Bone Meal";
            classType = this;
            image = "img/images/crafted/items/bone_meal.png";    
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Bone Meal has been placed");
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
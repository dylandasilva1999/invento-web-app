using System;

namespace invento_web_app
{
    class Bone: Item, Craft
    {
        private Recipe recipe;

        public Bone(int newCount): base(newCount)
        {
            blockType = "Bone";
            classType = this;
            image = "img/images/misc/bones.png";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Bone has been placed");
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
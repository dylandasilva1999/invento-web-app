using System;

namespace invento_web_app
{
    abstract class Food: Item
    {
        private int count;
        protected string foodBlockType;
        public string FoodBlockType
        {
            get{
                return foodBlockType;
            }
        }

        public Food()
        {
            count = 0;
        }

        public Food(int newCount)
        {
            count = newCount;
        }
    }
}
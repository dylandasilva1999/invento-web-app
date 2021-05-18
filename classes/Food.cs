using System;

namespace invento_web_app
{
    abstract class Food
    {
        private int count;
        protected string foodBlockType;
        protected static Food classType; 

        public int Count
        {
            get{
                return count;
            }
            set{
                if(value < 0)
                {   
                    count = -value;
                } else 
                {
                    count = value;
                }
                
            }
        }

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

        public static Food Get()
        {
            return classType;
        }

        public abstract void Place();
    }
}
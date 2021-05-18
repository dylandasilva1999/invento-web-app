using System;

namespace invento_web_app
{
    abstract class Basic
    {
        private int count;
        protected string basicBlockType;
        protected static Basic classType; 

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

        public string BasicBlockType
        {
            get{
                return basicBlockType;
            }
        }

        public Basic()
        {
            count = 0;
        }

        public Basic(int newCount)
        {
            count = newCount;
        }

        public static Basic Get()
        {
            return classType;
        }

        public abstract void Place();
    }
}
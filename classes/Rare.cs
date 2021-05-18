using System;

namespace invento_web_app
{
    abstract class Rare
    {
        private int count;
        protected string rareBlockType;
        protected static Rare classType;

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

        public string RareBlockType
        {
            get{
                return rareBlockType;
            }
        }

        public Rare()
        {
            count = 0;
        }

        public Rare(int newCount)
        {
            count = newCount;
        }

        public static Rare Get()
        {
            return classType;
        }

        public abstract void Place();
    }
}
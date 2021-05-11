using System;

namespace invento_web_app
{
    abstract class Rare
    {
        private int count;
        protected string rareBlockType;

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

        //public abstract void Place();
    }
}
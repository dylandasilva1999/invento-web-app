using System;

namespace invento_web_app
{
    abstract class Misc
    {
        private int count;
        protected string miscBlockType;

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

        public string MiscBlockType
        {
            get{
                return miscBlockType;
            }
        }

        public Misc()
        {
            count = 0;
        }

        public Misc(int newCount)
        {
            count = newCount;
        }

        //public abstract void Place();
    }
}
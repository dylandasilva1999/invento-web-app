using System;

namespace invento_web_app
{
    abstract class Misc
    {
        private int count;
        protected string miscBlockType;
        protected static Misc classType; 

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

        public static Misc Get()
        {
            return classType;
        }

        public abstract void Place();
    }
}
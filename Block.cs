using System;

namespace invento_web_app
{
    abstract class Block
    {
        private int count;
        protected string blockType;

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

        public string BlockType
        {
            get{
                return blockType;
            }
        }

        public Block()
        {
            count = 0;
        }

        public Block(int newCount)
        {
            count = newCount;
        }

        public abstract void Place();
    }
}
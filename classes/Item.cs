using System;

namespace invento_web_app
{
    abstract class Item
    {
		private static object blocksLock = new object();
        private int count;
        protected string blockType;
        protected string image;
        protected static Item classType;

        public int Count
        {
            get{
				lock(blocksLock)
				{
					return count;
				}
            }
            set{
				lock(blocksLock)
				{
					if(value < 0)
					{   
						count = -value;
					} else 
					{
						count = value;
					}
					
					Database.UpdateBlockCount(blockType, count);
				}
            }
        }

        public string BlockType
        {
            get{
                return blockType;
            }
        }
        public string Image
        {
            get
            {
                return image;
            }
        }

        public Item()
        {
            count = 0;
        }

        public Item(int newCount)
        {
            count = newCount;
        }

        public static Item Get()
        {
            return classType;
        }

        public abstract void Place();
    }
}
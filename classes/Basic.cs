using System;

namespace invento_web_app
{
    abstract class Basic: Item
    {
        private int count;
        protected string basicBlockType;
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
    }
}
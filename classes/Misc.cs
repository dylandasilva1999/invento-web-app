using System;

namespace invento_web_app
{
    abstract class Misc: Item
    {
        private int count;
        protected string miscBlockType;
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
    }
}
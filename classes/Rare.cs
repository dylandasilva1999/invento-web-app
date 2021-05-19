using System;

namespace invento_web_app
{
    abstract class Rare: Item
    {
        private int count;
        protected string rareBlockType;
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
    }
}
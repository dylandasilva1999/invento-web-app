using System;

namespace invento_web_app
{
    class WoodBlock: Block
    {
        public WoodBlock()
        {
            blockType = "Wood Block";
        }

        public WoodBlock(int newCount): base(newCount)
        {
            blockType   = "Wood Block";           
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Wood Block has been placed");
        }
    }
}
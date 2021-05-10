using System;

namespace invento_web_app
{
    class GlassBlock: Block
    {
        public GlassBlock()
        {
            blockType = "Glass Block";
        }

        public GlassBlock(int newCount): base(newCount)
        {
            blockType   = "Glass Block";           
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Glass Block has been placed");
        }
    }
}
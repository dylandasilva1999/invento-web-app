using System;

namespace invento_web_app
{
    class Coal: Block
    {
        public Coal(int newCount): base(newCount)
        {
            blockType = "Coal";
        }

        public override void Place()
        {
            Count--;
            Console.WriteLine("Coal has been placed");
        }
    }
}
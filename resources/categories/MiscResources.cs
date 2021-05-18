using System;

namespace invento_web_app
{
    //Leather inherit from Misc
    class Leather: Misc
    {
        public Leather(): base()
        {
            miscBlockType = "Leather";
        }
        public Leather(int newCount): base(newCount)
        {
            miscBlockType = "Leather"; 
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Leather has been placed");
        }
    }

    //Flint inherit from Misc
    class Flint: Misc
    {
        public Flint(): base()
        {
            miscBlockType = "Flint";
        }
        public Flint(int newCount): base(newCount)
        {
            miscBlockType = "Flint"; 
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Leather has been placed");
        }
        public void Smelt()
        {
            Console.WriteLine("Flint is smelting");
        }
    }

    //String inherit from Misc
    class String: Misc
    {
        public String(): base()
        {
            miscBlockType = "String";
        }
        public String(int newCount): base(newCount)
        {
            miscBlockType = "String"; 
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("String has been placed");
        }
    }

    //Feather inherit from Misc
    class Feather: Misc
    {
        public Feather(): base()
        {
            miscBlockType = "Feather";
        }
        public Feather(int newCount): base(newCount)
        {
            miscBlockType = "Feather"; 
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Feather has been placed");
        }
    }

    //Bones inherit from Misc
    class Bones: Misc
    {
        public Bones(): base()
        {
            miscBlockType = "Bones";
        }
        public Bones(int newCount): base(newCount)
        {
            miscBlockType = "Bones";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Bones has been placed");
        }

    }
}
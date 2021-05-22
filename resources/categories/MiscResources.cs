using System;

namespace invento_web_app
{
    //Leather inherit from Misc
    class Leather: Misc
    {
        public Leather(): base()
        {
            miscBlockType = "Leather";
            classType = this;
            image = "img/images/misc/leather.png";
        }
        public Leather(int newCount): base(newCount)
        {
            miscBlockType = "Leather";
            image = "img/images/misc/leather.png"; 
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
            classType = this;
            image = "img/images/misc/flint.png";
        }
        public Flint(int newCount): base(newCount)
        {
            miscBlockType = "Flint";
            image = "img/images/misc/flint.png"; 
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
            classType = this;
            image = "img/images/misc/string.png";
        }
        public String(int newCount): base(newCount)
        {
            miscBlockType = "String";
            image = "img/images/misc/string.png";
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
            classType = this;
            image = "img/images/misc/feather.png";
        }
        public Feather(int newCount): base(newCount)
        {
            miscBlockType = "Feather";
            image = "img/images/misc/feather.png";
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
            classType = this;
            image = "img/images/misc/bones.png";
        }
        public Bones(int newCount): base(newCount)
        {
            miscBlockType = "Bones";
            image = "img/images/misc/bones.png";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Bones has been placed");
        }

    }
}
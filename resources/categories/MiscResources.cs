using System;

namespace invento_web_app
{
    //Leather inherit from Misc
    class LeatherResource: Misc
    {
        public LeatherResource(): base()
        {
            miscBlockType = "Leather";
            classType = this;
            image = "img/images/misc/leather.png";
        }
        public LeatherResource(int newCount): base(newCount)
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
    class FlintResource: Misc
    {
        public FlintResource(): base()
        {
            miscBlockType = "Flint";
            classType = this;
            image = "img/images/misc/flint.png";
        }
        public FlintResource(int newCount): base(newCount)
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
    class StringResource: Misc
    {
        public StringResource(): base()
        {
            miscBlockType = "String";
            classType = this;
            image = "img/images/misc/string.png";
        }
        public StringResource(int newCount): base(newCount)
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
    class FeatherResource: Misc
    {
        public FeatherResource(): base()
        {
            miscBlockType = "Feather";
            classType = this;
            image = "img/images/misc/feather.png";
        }
        public FeatherResource(int newCount): base(newCount)
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
    class BonesResource: Misc
    {
        public BonesResource(): base()
        {
            miscBlockType = "Bones";
            classType = this;
            image = "img/images/misc/bones.png";
        }
        public BonesResource(int newCount): base(newCount)
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
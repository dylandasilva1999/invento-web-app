using System;

namespace invento_web_app
{
    //Wood inherit from Basic
    class WoodResource: Basic, Flammable
    {
        public WoodResource(): base()
        {
            basicBlockType = "Wood Block";
            classType = this;
            image = "img/images/basic/log.png";
        }
        public WoodResource(int newCount): base(newCount)
        {
            basicBlockType = "Wood Block";
            image = "img/images/basic/log.png";
        }

        public override void Place()
        {
            Count --;
            Console.WriteLine("Wood has been placed");
        }
        public void Burn()
        {
            Console.WriteLine("Wood is burning");
        }
        
    }

    //Cobblestone inherit from Basic
    class CobblestoneResource: Basic
    {
        public CobblestoneResource(): base()
        {
            basicBlockType = "Cobblestone Block";
            classType = this;
            image = "img/images/basic/cobblestone.png";
        }
        public CobblestoneResource(int newCount): base(newCount)
        {
            basicBlockType = "Cobblestone Block";
            image = "img/images/basic/cobblestone.png";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Cobblestone has been placed");
        }
        public void Melt()
        {
            Console.WriteLine("Cobblestone is melting");
        }
    }

    //Wool inherit from Basic
    class WoolResource: Basic, Flammable
    {
        public WoolResource(): base()
        {
            basicBlockType = "Wool Block";
            classType = this;
            image = "img/images/basic/wool.png";
        }
        public WoolResource(int newCount): base(newCount)
        {
            basicBlockType = "Wool Block";
            image = "img/images/basic/wool.png";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Wool has been placed");
        }

        public void Burn()
        {
            Console.WriteLine("Wool is burning");
        }
    }

    //Sand inherit from Basic
    class SandResource: Basic
    {
        public SandResource(): base()
        {
            basicBlockType = "Sand Block";
            classType = this;
            image = "img/images/basic/sand.png";
        }
        public SandResource(int newCount): base(newCount)
        {
            basicBlockType = "Sand Block";
            image = "img/images/basic/sand.png";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Sand has been placed");
        }

        public void Melt()
        {
            Console.WriteLine("Sand is melting");
        }
    }

    //WoodPlanks inherit from Basic
    class WoodPlankResource: Basic, Flammable
    {
        public WoodPlankResource(): base()
        {
            basicBlockType = "Wood Planks";
            classType = this;
            image = "img/images/basic/plank.png";
        }
        public WoodPlankResource(int newCount): base(newCount)
        {
            basicBlockType = "Wood Planks";
            image = "img/images/basic/plank.png";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Wood Planks has been placed");
        }

        public void Burn()
        {
            Console.WriteLine("Wood Planks are burning");
        }
        public void Melt()
        {
            Console.WriteLine("Wood Plank is melting");
        }
    }
}
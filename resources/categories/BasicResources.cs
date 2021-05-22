using System;

namespace invento_web_app
{
    //Wood inherit from Basic
    class Wood: Basic, Flammable
    {
        public Wood(): base()
        {
            basicBlockType = "Wood Block";
            classType = this;
            image = "img/images/basic/log.png";
        }
        public Wood(int newCount): base(newCount)
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
    class Cobblestone: Basic
    {
        public Cobblestone(): base()
        {
            basicBlockType = "Cobblestone Block";
            classType = this;
            image = "img/images/basic/cobblestone.png";
        }
        public Cobblestone(int newCount): base(newCount)
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
    class Wool: Basic, Flammable
    {
        public Wool(): base()
        {
            basicBlockType = "Wool Block";
            classType = this;
            image = "img/images/basic/wool.png";
        }
        public Wool(int newCount): base(newCount)
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
    class Sand: Basic
    {
        public Sand(): base()
        {
            basicBlockType = "Sand Block";
            classType = this;
            image = "img/images/basic/sand.png";
        }
        public Sand(int newCount): base(newCount)
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
    class WoodPlank: Basic, Flammable
    {
        public WoodPlank(): base()
        {
            basicBlockType = "Wood Planks";
            classType = this;
            image = "img/images/basic/plank.png";
        }
        public WoodPlank(int newCount): base(newCount)
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
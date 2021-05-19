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
        }
        public Wood(int newCount): base(newCount)
        {
            basicBlockType = "Wood Block";
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
        }
        public Cobblestone(int newCount): base(newCount)
        {
            basicBlockType = "Cobblestone Block"; 
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
        }
        public Wool(int newCount): base(newCount)
        {
            basicBlockType = "Wool Block"; 
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
        }
        public Sand(int newCount): base(newCount)
        {
            basicBlockType = "Sand Block"; 
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
        }
        public WoodPlank(int newCount): base(newCount)
        {
            basicBlockType = "Wood Planks"; 
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
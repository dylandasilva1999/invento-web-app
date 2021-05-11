using System;

namespace invento_web_app
{
    //Wood inherit from Basic
    class Wood: Basic
    {
        public Wood(): base()
        {
            basicBlockType = "Wood Block";
        }
        public Wood(int newCount): base(newCount)
        {
            basicBlockType = "Wood Block";
        }

    }

    //Cobblestone inherit from Basic
    class Cobblestone: Basic
    {
        public Cobblestone(): base()
        {
            basicBlockType = "Cobblestone Block";
        }
        public Cobblestone(int newCount): base(newCount)
        {
            basicBlockType = "Cobblestone Block"; 
        }

    }

    //Wool inherit from Basic
    class Wool: Basic
    {
        public Wool(): base()
        {
            basicBlockType = "Wool Block";
        }
        public Wool(int newCount): base(newCount)
        {
            basicBlockType = "Wool Block"; 
        }

    }

    //Sand inherit from Basic
    class Sand: Basic
    {
        public Sand(): base()
        {
            basicBlockType = "Sand Block";
        }
        public Sand(int newCount): base(newCount)
        {
            basicBlockType = "Sand Block"; 
        }

    }

    //WoodPlanks inherit from Basic
    class WoodPlanks: Basic
    {
        public WoodPlanks(): base()
        {
            basicBlockType = "Wood Planks";
        }
        public WoodPlanks(int newCount): base(newCount)
        {
            basicBlockType = "Wood Planks"; 
        }

    }
}
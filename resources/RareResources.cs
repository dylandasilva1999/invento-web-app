using System;

namespace invento_web_app
{
    //DiamondIgnot inherit from Rare
    class DiamondIgnot: Rare
    {
        public DiamondIgnot(): base()
        {
            rareBlockType = "Diamond Ignot";
        }
        public DiamondIgnot(int newCount): base(newCount)
        {
            rareBlockType = "Diamond Ignot"; 
        }

    }

    //GoldIgnot inherit from Rare
    class GoldIgnot: Rare
    {
        public GoldIgnot(): base()
        {
            rareBlockType = "Gold Ignot";
        }
        public GoldIgnot(int newCount): base(newCount)
        {
            rareBlockType = "Gold Ignot"; 
        }

    }

    //IronIgnot inherit from Rare
    class IronIgnot: Rare
    {
        public IronIgnot(): base()
        {
            rareBlockType = "Iron Ignot";
        }
        public IronIgnot(int newCount): base(newCount)
        {
            rareBlockType = "Iron Ignot"; 
        }

    }

    //Coal inherit from Rare
    class Coal: Rare
    {
        public Coal(): base()
        {
            rareBlockType = "Coal";
        }
        public Coal(int newCount): base(newCount)
        {
            rareBlockType = "Coal"; 
        }

    }

    //RedstoneDust inherit from Rare
    class RedstoneDust: Rare
    {
        public RedstoneDust(): base()
        {
            rareBlockType = "Redstone Dust";
        }
        public RedstoneDust(int newCount): base(newCount)
        {
            rareBlockType = "Redstone Dust";
        }

    }
}
using System;

namespace invento_web_app
{
    //DiamondIgnot inherit from Rare
    class DiamondIgnotResource: Rare
    {
        public DiamondIgnotResource(): base()
        {
            rareBlockType = "Diamond Ignot";
            classType = this;
            image = "img/images/rare/diamond.png";
        }
        public DiamondIgnotResource(int newCount): base(newCount)
        {
            rareBlockType = "Diamond Ignot";
            image = "img/images/rare/diamond.png";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("DiamondIgnot has been placed");
        }
        public void Smelt()
        {
            Console.WriteLine("DiamondIgnot is smelting");
        }
    }

    //GoldIgnot inherit from Rare
    class GoldIgnotResource: Rare
    {
        public GoldIgnotResource(): base()
        {
            rareBlockType = "Gold Ignot";
            classType = this;
            image = "img/images/rare/gold.png";
        }
        public GoldIgnotResource(int newCount): base(newCount)
        {
            rareBlockType = "Gold Ignot";
            image = "img/images/rare/gold.png";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("GoldIgnot has been placed");
        }
        public void Smelt()
        {
            Console.WriteLine("GoldIgnot is smelting");
        }
    }

    //IronIgnot inherit from Rare
    class IronIgnotResource: Rare
    {
        public IronIgnotResource(): base()
        {
            rareBlockType = "Iron Ignot";
            classType = this;
            image = "img/images/rare/iron.png";
        }
        public IronIgnotResource(int newCount): base(newCount)
        {
            rareBlockType = "Iron Ignot";
            image = "img/images/rare/iron.png"; 
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("IronIgnot has been placed");
        }
        public void Smelt()
        {
            Console.WriteLine("IronIgnot is smelting");
        }
    }

    //Coal inherit from Rare
    class CoalResource: Rare
    {
        public CoalResource(): base()
        {
            rareBlockType = "Coal";
            classType = this;
            image = "img/images/rare/coal.png";
        }
        public CoalResource(int newCount): base(newCount)
        {
            rareBlockType = "Coal";
            image = "img/images/rare/coal.png"; 
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Coal has been placed");
        }
        public void Smelt()
        {
            Console.WriteLine("Coal is smelting");
        }
        public void Melt()
        {
            Console.WriteLine("Coal is melting");
        }
    }

    //RedstoneDust inherit from Rare
    class RedstoneDustResource: Rare
    {
        public RedstoneDustResource(): base()
        {
            rareBlockType = "Redstone Dust";
            classType = this;
            image = "img/images/rare/redstone.png";
        }
        public RedstoneDustResource(int newCount): base(newCount)
        {
            rareBlockType = "Redstone Dust";
            image = "img/images/rare/redstone.png";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("RedstoneDust has been placed");
        }
    }
}
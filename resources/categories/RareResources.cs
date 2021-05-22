using System;

namespace invento_web_app
{
    //DiamondIgnot inherit from Rare
    class DiamondIgnot: Rare
    {
        public DiamondIgnot(): base()
        {
            rareBlockType = "Diamond Ignot";
            classType = this;
            image = "img/images/rare/diamond.png";
        }
        public DiamondIgnot(int newCount): base(newCount)
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
    class GoldIgnot: Rare
    {
        public GoldIgnot(): base()
        {
            rareBlockType = "Gold Ignot";
            classType = this;
            image = "img/images/rare/gold.png";
        }
        public GoldIgnot(int newCount): base(newCount)
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
    class IronIgnot: Rare
    {
        public IronIgnot(): base()
        {
            rareBlockType = "Iron Ignot";
            classType = this;
            image = "img/images/rare/iron.png";
        }
        public IronIgnot(int newCount): base(newCount)
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
    class Coal: Rare
    {
        public Coal(): base()
        {
            rareBlockType = "Coal";
            classType = this;
            image = "img/images/rare/coal.png";
        }
        public Coal(int newCount): base(newCount)
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
    class RedstoneDust: Rare
    {
        public RedstoneDust(): base()
        {
            rareBlockType = "Redstone Dust";
            classType = this;
            image = "img/images/rare/redstone.png";
        }
        public RedstoneDust(int newCount): base(newCount)
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
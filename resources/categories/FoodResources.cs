using System;

namespace invento_web_app
{
    //Wheat inherit from Food
    class Wheat: Food
    {
        public Wheat(): base()
        {
            foodBlockType = "Wheat";
        }
        public Wheat(int newCount): base(newCount)
        {
            foodBlockType = "Wheat"; 
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Wheat has been placed");
        }
    }

    //GoldIgnot inherit from Food
    class Melon: Food
    {
        public Melon(): base()
        {
            foodBlockType = "Melon";
        }
        public Melon(int newCount): base(newCount)
        {
            foodBlockType = "Melon"; 
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Melon has been placed");
        }
    }

    //IronIgnot inherit from Food
    class Pumpkin: Food
    {
        public Pumpkin(): base()
        {
            foodBlockType = "Pumpkin";
        }
        public Pumpkin(int newCount): base(newCount)
        {
            foodBlockType = "Pumpkin"; 
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Pumpkin has been placed");
        }
    }

    //Coal inherit from Food
    class Apple: Food
    {
        public Apple(): base()
        {
            foodBlockType = "Apple";
        }
        public Apple(int newCount): base(newCount)
        {
            foodBlockType = "Apple"; 
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Apple has been placed");
        }
    }

    //RedstoneDust inherit from Food
    class Carrot: Food
    {
        public Carrot(): base()
        {
            foodBlockType = "Carrot";
        }
        public Carrot(int newCount): base(newCount)
        {
            foodBlockType = "Carrot";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Carrot has been placed");
        }
    }
}
using System;

namespace invento_web_app
{
    //Wheat inherit from Food
    class Wheat: Food
    {
        public Wheat(): base()
        {
            foodBlockType = "Wheat";
            classType = this;
            image = "img/images/food/wheat.png";
        }
        public Wheat(int newCount): base(newCount)
        {
            foodBlockType = "Wheat";
            image = "img/images/food/wheat.png";
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
            classType = this;
            image = "img/images/food/melon.png";
        }
        public Melon(int newCount): base(newCount)
        {
            foodBlockType = "Melon";
            image = "img/images/food/melon.png";
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
            classType = this;
            image = "img/images/food/pumpkin.png";
        }
        public Pumpkin(int newCount): base(newCount)
        {
            foodBlockType = "Pumpkin";
            image = "img/images/food/pumpkin.png"; 
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
            classType = this;
            image = "img/images/food/apple.png";
        }
        public Apple(int newCount): base(newCount)
        {
            foodBlockType = "Apple";
            image = "img/images/food/apple.png";
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
            image = "img/images/food/carrot.png";
            classType = this;
        }
        public Carrot(int newCount): base(newCount)
        {
            foodBlockType = "Carrot";
            image = "img/images/food/carrot.png";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Carrot has been placed");
        }
    }
}
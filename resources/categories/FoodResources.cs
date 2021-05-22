using System;

namespace invento_web_app
{
    //Wheat inherit from Food
    class WheatResource: Food
    {
        public WheatResource(): base()
        {
            foodBlockType = "Wheat";
            classType = this;
            image = "img/images/food/wheat.png";
        }
        public WheatResource(int newCount): base(newCount)
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
    class MelonSliceResource: Food
    {
        public MelonSliceResource(): base()
        {
            foodBlockType = "Melon Slice";
            classType = this;
            image = "img/images/food/melon_slice.png";
        }
        public MelonSliceResource(int newCount): base(newCount)
        {
            foodBlockType = "Melon Slice";
            image = "img/images/food/melon_slice.png";
        }
        public override void Place()
        {
            Count --;
            Console.WriteLine("Melon has been placed");
        }
    }

    //IronIgnot inherit from Food
    class PumpkinResource: Food
    {
        public PumpkinResource(): base()
        {
            foodBlockType = "Pumpkin";
            classType = this;
            image = "img/images/food/pumpkin.png";
        }
        public PumpkinResource(int newCount): base(newCount)
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
    class AppleResource: Food
    {
        public AppleResource(): base()
        {
            foodBlockType = "Apple";
            classType = this;
            image = "img/images/food/apple.png";
        }
        public AppleResource(int newCount): base(newCount)
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
    class CarrotResource: Food
    {
        public CarrotResource(): base()
        {
            foodBlockType = "Carrot";
            image = "img/images/food/carrot.png";
            classType = this;
        }
        public CarrotResource(int newCount): base(newCount)
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
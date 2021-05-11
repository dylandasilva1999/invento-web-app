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

    }
}
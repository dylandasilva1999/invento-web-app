using System;

namespace invento_web_app
{
    //Leather inherit from Misc
    class Leather: Misc
    {
        public Leather(): base()
        {
            miscBlockType = "Leather";
        }
        public Leather(int newCount): base(newCount)
        {
            miscBlockType = "Leather"; 
        }

    }

    //Flint inherit from Misc
    class Flint: Misc
    {
        public Flint(): base()
        {
            miscBlockType = "Flint";
        }
        public Flint(int newCount): base(newCount)
        {
            miscBlockType = "Flint"; 
        }

    }

    //String inherit from Misc
    class String: Misc
    {
        public String(): base()
        {
            miscBlockType = "String";
        }
        public String(int newCount): base(newCount)
        {
            miscBlockType = "String"; 
        }

    }

    //Feather inherit from Misc
    class Feather: Misc
    {
        public Feather(): base()
        {
            miscBlockType = "Feather";
        }
        public Feather(int newCount): base(newCount)
        {
            miscBlockType = "Feather"; 
        }

    }

    //Bones inherit from Misc
    class Bones: Misc
    {
        public Bones(): base()
        {
            miscBlockType = "Bones";
        }
        public Bones(int newCount): base(newCount)
        {
            miscBlockType = "Bones";
        }

    }
}
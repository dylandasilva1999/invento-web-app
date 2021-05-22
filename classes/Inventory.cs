using System;
using System.Collections;

namespace invento_web_app
{
    class Inventory
    {
        private static ArrayList items = new ArrayList();

        public Inventory()
        {
            items.Add(new Cobblestone(10));
            items.Add(new Wood(10));
            items.Add(new WoodPlank(10));
            items.Add(new Wool(10));
            items.Add(new Sand(10));
            items.Add(new Apple(10));
            items.Add(new Pumpkin(10));
            items.Add(new MelonSlice(10));
            items.Add(new Carrot(10));
            items.Add(new Wheat(10));
            items.Add(new Leather(10));
            items.Add(new Flint(10));
            items.Add(new Bones(10));
            items.Add(new String(10));
            items.Add(new Feather(10));
            items.Add(new DiamondIgnot(10));
            items.Add(new GoldIgnot(10));
            items.Add(new IronIgnot(10));
            items.Add(new Coal(10));
            items.Add(new RedstoneDust(10));
            items.Add(new Stick(0));
        }

        public ArrayList Items
        {
            get 
            {
                return items;
            }
        }

        public static int GetCount(string index)
        {
            foreach (Item curItem in items)
            {
                if (curItem.BlockType == index)
                    return curItem.Count;
            }

            return -1;
        }
    }
}
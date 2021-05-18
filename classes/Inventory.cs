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
            foreach (Basic curBasicItem in items)
            {
                if (curBasicItem.BasicBlockType == index)
                    return curBasicItem.Count;
            }

            foreach (Food curFoodItem in items)
            {
                if (curFoodItem.FoodBlockType == index)
                    return curFoodItem.Count;
            }

            foreach (Misc curMiscItem in items)
            {
                if (curMiscItem.MiscBlockType == index)
                    return curMiscItem.Count;
            }

            foreach (Rare curRareItem in items)
            {
                if (curRareItem.RareBlockType == index)
                    return curRareItem.Count;
            }

            return -1;
        }
    }
}
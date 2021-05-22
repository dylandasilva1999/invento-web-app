using System;
using System.Collections;

namespace invento_web_app
{
    class Inventory
    {
        private static ArrayList items = new ArrayList();

        public Inventory()
        {
            // WOOD ITEMS
            items.Add(new Wood(1));
            items.Add(new WoodPlank(1));
            items.Add(new WoodHoe(1));
            items.Add(new WoodAxe(1));
            items.Add(new WoodPickAxe(1));
            items.Add(new WoodShovel(1));
            items.Add(new WoodSword(1));

            // STONE ITEMS
            items.Add(new Cobblestone(1));
            items.Add(new StoneHoe(1));
            items.Add(new StonePickAxe(1));
            items.Add(new StoneAxe(1));
            items.Add(new StoneShovel(1));
            items.Add(new StoneSword(1));
            
            // IRON ITEMS
            items.Add(new IronIgnot(1));
            items.Add(new IronHoe(1));
            items.Add(new IronPickAxe(1));
            items.Add(new IronAxe(1));
            items.Add(new IronShovel(1));
            items.Add(new IronSword(1));

            // GOLD ITEMS
            items.Add(new GoldIgnot(1));
            items.Add(new GoldHoe(1));
            items.Add(new GoldPickAxe(1));
            items.Add(new GoldAxe(1));
            items.Add(new GoldShovel(1));
            items.Add(new GoldSword(1));

            // DIAMOND ITEMS
            items.Add(new DiamondIgnot(1));
            items.Add(new DiamondHoe(1));
            items.Add(new DiamondPickAxe(1));
            items.Add(new DiamondAxe(1));
            items.Add(new DiamondShovel(1));
            items.Add(new DiamondSword(1));

            //ITEMS
            items.Add(new Arrow(10));
            items.Add(new Bed(10));
            items.Add(new BoneMeal(10));
            items.Add(new Bow(10));
            items.Add(new Bread(10));
            items.Add(new Chest(10));
            items.Add(new Compass(10));
            items.Add(new CraftTable(10));
            items.Add(new Door(10));
            items.Add(new FishingRod(10));
            items.Add(new FletchingTable(10));
            items.Add(new FlintSteel(10));
            items.Add(new FurnaceItem(10));
            items.Add(new GlassBlock(10));
            items.Add(new GoldenApple(10));
            items.Add(new HayBale(10));
            items.Add(new ItemFrame(10));
            items.Add(new Ladder(10));
            items.Add(new Melon(10));
            items.Add(new Painting(10));
            items.Add(new Piston(10));
            items.Add(new RedstoneTorch(10));
            items.Add(new Stick(10));
            items.Add(new Torch(10));
            items.Add(new RedstoneDust(10));
            items.Add(new Wool(10));
            items.Add(new Sand(10));
            items.Add(new Apple(10));
            items.Add(new Wheat(10));
            items.Add(new MelonSlice(10));
            items.Add(new Pumpkin(10));
            items.Add(new Carrot(10));
            items.Add(new Leather(10));
            items.Add(new Flint(10));
            items.Add(new String(10));
            items.Add(new Feather(10));
            items.Add(new Bones(10));
            items.Add(new Coal(10));
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
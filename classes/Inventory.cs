using System;
using System.Collections;

namespace invento_web_app
{
    class Inventory
    {
        private static ArrayList items = new ArrayList();
        public Inventory()
        {
            ArrayList data = Database.ReadItems();

            foreach(Tuple<string, int, string>curTuple in data)
            {
                Item newItem;

                switch (curTuple.Item1)
                {
                    //WOOD ITEMS
                    case "Wood Hoe":
                        newItem = new WoodHoe(curTuple.Item2);
                        break;
                    case "Wood Axe":
                        newItem = new WoodAxe(curTuple.Item2);
                        break;
                    case "Wood Pick Axe":
                        newItem = new WoodPickAxe(curTuple.Item2);
                        break;
                    case "Wood Shovel":
                        newItem = new WoodShovel(curTuple.Item2);
                        break;
                    case "Wood Sword":
                        newItem = new WoodSword(curTuple.Item2);
                        break;

                    //STONE ITEMS
                    case "Stone Hoe":
                        newItem = new StoneHoe(curTuple.Item2);
                        break;
                    case "Stone Axe":
                        newItem = new StoneAxe(curTuple.Item2);
                        break;
                    case "Stone Pick Axe":
                        newItem = new StonePickAxe(curTuple.Item2);
                        break;
                    case "Stone Shovel":
                        newItem = new StoneShovel(curTuple.Item2);
                        break;
                    case "Stone Sword":
                        newItem = new StoneSword(curTuple.Item2);
                        break;

                    //IRON ITEMS
                    case "Iron Hoe":
                        newItem = new IronHoe(curTuple.Item2);
                        break;
                    case "Iron Axe":
                        newItem = new IronAxe(curTuple.Item2);
                        break;
                    case "Iron Pick Axe":
                        newItem = new IronPickAxe(curTuple.Item2);
                        break;
                    case "Iron Shovel":
                        newItem = new IronShovel(curTuple.Item2);
                        break;
                    case "Iron Sword":
                        newItem = new IronSword(curTuple.Item2);
                        break;

                    //GOLD ITEMS
                    case "Gold Hoe":
                        newItem = new GoldHoe(curTuple.Item2);
                        break;
                    case "Gold Axe":
                        newItem = new GoldAxe(curTuple.Item2);
                        break;
                    case "Gold Pick Axe":
                        newItem = new GoldPickAxe(curTuple.Item2);
                        break;
                    case "Gold Shovel":
                        newItem = new GoldShovel(curTuple.Item2);
                        break;
                    case "Gold Sword":
                        newItem = new GoldSword(curTuple.Item2);
                        break;

                    //DIAMOND ITEMS
                    case "Diamond Hoe":
                        newItem = new DiamondHoe(curTuple.Item2);
                        break;
                    case "Diamond Axe":
                        newItem = new DiamondAxe(curTuple.Item2);
                        break;
                    case "Diamond Pick Axe":
                        newItem = new DiamondPickAxe(curTuple.Item2);
                        break;
                    case "Diamond Shovel":
                        newItem = new DiamondShovel(curTuple.Item2);
                        break;
                    case "Diamond Sword":
                        newItem = new DiamondSword(curTuple.Item2);
                        break;

                    //BASIC ESSENTIAL RESOURCES
                    case "Cobblestone":
                        newItem = new Cobblestone(curTuple.Item2);
                        break;
                    case "Sand":
                        newItem = new Sand(curTuple.Item2);
                        break;
                    case "Wood Log":
                        newItem = new WoodLog(curTuple.Item2);
                        break;
                    case "Wood Plank":
                        newItem = new WoodPlank(curTuple.Item2);
                        break;
                    case "Wool":
                        newItem = new Wool(curTuple.Item2);
                        break;

                    //FOOD ESSENTIAL RESOURCES
                    case "Apple":
                        newItem = new Apple(curTuple.Item2);
                        break;
                    case "Carrot":
                        newItem = new Carrot(curTuple.Item2);
                        break;
                    case "Melon Slice":
                        newItem = new MelonSlice(curTuple.Item2);
                        break;
                    case "Pumpkin":
                        newItem = new Pumpkin(curTuple.Item2);
                        break;
                    case "Wheat":
                        newItem = new Wheat(curTuple.Item2);
                        break;

                    //MISC ESSENTIAL RESOURCES
                    case "Bone":
                        newItem = new Bone(curTuple.Item2);
                        break;
                    case "Feather":
                        newItem = new Feather(curTuple.Item2);
                        break;
                    case "Flint":
                        newItem = new Flint(curTuple.Item2);
                        break;
                    case "Leather":
                        newItem = new Leather(curTuple.Item2);
                        break;
                    case "String":
                        newItem = new String(curTuple.Item2);
                        break;

                    //RARE ESSENTIAL RESOURCES
                    case "Coal":
                        newItem = new Coal(curTuple.Item2);
                        break;
                    case "Diamond Ignot":
                        newItem = new DiamondIgnot(curTuple.Item2);
                        break;
                    case "Gold Ignot":
                        newItem = new GoldIgnot(curTuple.Item2);
                        break;
                    case "Iron Ignot":
                        newItem = new IronIgnot(curTuple.Item2);
                        break;
                    case "Redstone Dust":
                        newItem = new RedstoneDust(curTuple.Item2);
                        break;

                    //ITEMS
                    case "Arrow":
                        newItem = new Arrow(curTuple.Item2);
                        break;
                    case "Bed":
                        newItem = new Bed(curTuple.Item2);
                        break;
                    case "Bone Meal":
                        newItem = new BoneMeal(curTuple.Item2);
                        break;
                    case "Bow":
                        newItem = new Bow(curTuple.Item2);
                        break;
                    case "Bread":
                        newItem = new Bread(curTuple.Item2);
                        break;
                    case "Chest":
                        newItem = new Chest(curTuple.Item2);
                        break;
                    case "Compass":
                        newItem = new Compass(curTuple.Item2);
                        break;
                    case "Crafting Table":
                        newItem = new CraftTable(curTuple.Item2);
                        break;
                    case "Door":
                        newItem = new Door(curTuple.Item2);
                        break;
                    case "Fishing Rod":
                        newItem = new FishingRod(curTuple.Item2);
                        break;
                    case "Fletching Table":
                        newItem = new FletchingTable(curTuple.Item2);
                        break;
                    case "Flint and Steel":
                        newItem = new FlintSteel(curTuple.Item2);
                        break;
                    case "Furnace":
                        newItem = new FurnaceItem(curTuple.Item2);
                        break;
                    case "Glass Block":
                        newItem = new GlassBlock(curTuple.Item2);
                        break;
                    case "Golden Apple":
                        newItem = new GoldenApple(curTuple.Item2);
                        break;
                    case "Hay Bale":
                        newItem = new HayBale(curTuple.Item2);
                        break;
                    case "Item Frame":
                        newItem = new ItemFrame(curTuple.Item2);
                        break;
                    case "Ladder":
                        newItem = new Ladder(curTuple.Item2);
                        break;
                    case "Melon":
                        newItem = new Melon(curTuple.Item2);
                        break;
                    case "Painting":
                        newItem = new Painting(curTuple.Item2);
                        break;
                    case "Piston":
                        newItem = new Piston(curTuple.Item2);
                        break;
                    case "Redstone Torch":
                        newItem = new RedstoneTorch(curTuple.Item2);
                        break;
                    case "Stick":
                        newItem = new Stick(curTuple.Item2);
                        break;
                    case "Torch":
                        newItem = new Torch(curTuple.Item2);
                        break;
                    default:
                        newItem = null;
                        break;                                                  
                }
                
                items.Add(newItem);
            }
        }

        public static ArrayList Items
        {
            get 
            {
                return items;
            }
        }

        public static Item GetClass(string index)
        {
            foreach(Item curItem in items)
            {
                if(curItem.BlockType == index)
                    return curItem;
            }

            return null;
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
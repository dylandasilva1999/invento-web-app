using System;
using System.Collections;

namespace invento_web_app
{
    class RecipeBook
    {
        private static ArrayList recipes = new ArrayList();
        public static void Populate()
        {
            // ! WOOD TOOLS RECIPES
            // WOOD AXE RECIPE
            Recipe woodAxeRecipe = new Recipe((Craft) WoodAxe.Get(), new Item[3,3] {{WoodPlank.Get(), WoodPlank.Get(), null}, 
                                                                {WoodPlank.Get(), Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // WOOD HOE RECIPE
            Recipe woodHoeRecipe = new Recipe((Craft) WoodHoe.Get(), new Item[3,3] {{WoodPlank.Get(), WoodPlank.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // WOOD PICK AXE RECIPE
            Recipe woodPickAxeRecipe = new Recipe((Craft) WoodPickAxe.Get(), new Item[3,3] {{WoodPlank.Get(), WoodPlank.Get(), WoodPlank.Get()}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});                                                                                                      

            // WOOD SHOVEL RECIPE
            Recipe woodShovelRecipe = new Recipe((Craft) WoodShovel.Get(), new Item[3,3] {{null, WoodPlank.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // WOOD SWORD RECIPE
            Recipe woodSwordRecipe = new Recipe((Craft) WoodSword.Get(), new Item[3,3] {{null, WoodPlank.Get(), null}, 
                                                                {null, WoodPlank.Get(), null},
                                                                {null, Stick.Get(), null}});

            //ADD WOOD TOOLS RECIPES TO ARRAY                                                   
            recipes.Add(woodAxeRecipe);
            recipes.Add(woodHoeRecipe);
            recipes.Add(woodPickAxeRecipe);
            recipes.Add(woodShovelRecipe);
            recipes.Add(woodSwordRecipe);

            // ! STONE TOOLS RECIPES
            // STONE AXE RECIPE
            Recipe stoneAxeRecipe = new Recipe((Craft) StoneAxe.Get(), new Item[3,3] {{Cobblestone.Get(), Cobblestone.Get(), null}, 
                                                                {Cobblestone.Get(), Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // STONE HOE RECIPE
            Recipe stoneHoeRecipe = new Recipe((Craft) StoneHoe.Get(), new Item[3,3] {{Cobblestone.Get(), Cobblestone.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // STONE PICK AXE RECIPE
            Recipe stonePickAxeRecipe = new Recipe((Craft) StonePickAxe.Get(), new Item[3,3] {{Cobblestone.Get(), Cobblestone.Get(), Cobblestone.Get()}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});                                                                                                      

            // STONE SHOVEL RECIPE
            Recipe stoneShovelRecipe = new Recipe((Craft) StoneShovel.Get(), new Item[3,3] {{null, Cobblestone.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // STONE SWORD RECIPE
            Recipe stoneSwordRecipe = new Recipe((Craft) StoneSword.Get(), new Item[3,3] {{null, Cobblestone.Get(), null}, 
                                                                {null, WoodPlank.Get(), null},
                                                                {null, Stick.Get(), null}});

            //ADD STONE TOOLS RECIPES TO ARRAY                                                   
            recipes.Add(stoneAxeRecipe);
            recipes.Add(stoneHoeRecipe);
            recipes.Add(stonePickAxeRecipe);
            recipes.Add(stoneShovelRecipe);
            recipes.Add(stoneSwordRecipe);

            // ! IRON TOOLS RECIPES
            // IRON AXE RECIPE
            Recipe ironAxeRecipe = new Recipe((Craft) IronAxe.Get(), new Item[3,3] {{IronIgnot.Get(), IronIgnot.Get(), null}, 
                                                                {IronIgnot.Get(), Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // IRON HOE RECIPE
            Recipe ironHoeRecipe = new Recipe((Craft) IronHoe.Get(), new Item[3,3] {{IronIgnot.Get(), IronIgnot.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // IRON PICK AXE RECIPE
            Recipe ironPickAxeRecipe = new Recipe((Craft) IronPickAxe.Get(), new Item[3,3] {{IronIgnot.Get(), IronIgnot.Get(), IronIgnot.Get()}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});                                                                                                      

            // IRON SHOVEL RECIPE
            Recipe ironShovelRecipe = new Recipe((Craft) IronShovel.Get(), new Item[3,3] {{null, IronIgnot.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // IRON SWORD RECIPE
            Recipe ironSwordRecipe = new Recipe((Craft) IronSword.Get(), new Item[3,3] {{null, IronIgnot.Get(), null}, 
                                                                {null, IronIgnot.Get(), null},
                                                                {null, Stick.Get(), null}});

            //ADD IRON TOOLS RECIPES TO ARRAY                                                   
            recipes.Add(ironAxeRecipe);
            recipes.Add(ironHoeRecipe);
            recipes.Add(ironPickAxeRecipe);
            recipes.Add(ironShovelRecipe);
            recipes.Add(ironSwordRecipe);

            // ! GOLD TOOLS RECIPES
            // GOLD AXE RECIPE
            Recipe goldAxeRecipe = new Recipe((Craft) GoldAxe.Get(), new Item[3,3] {{GoldIgnot.Get(), GoldIgnot.Get(), null}, 
                                                                {GoldIgnot.Get(), Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // GOLD HOE RECIPE
            Recipe goldHoeRecipe = new Recipe((Craft) GoldHoe.Get(), new Item[3,3] {{GoldIgnot.Get(), GoldIgnot.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // GOLD PICK AXE RECIPE
            Recipe goldPickAxeRecipe = new Recipe((Craft) GoldPickAxe.Get(), new Item[3,3] {{GoldIgnot.Get(), GoldIgnot.Get(), GoldIgnot.Get()}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});                                                                                                      

            // GOLD SHOVEL RECIPE
            Recipe goldShovelRecipe = new Recipe((Craft) GoldShovel.Get(), new Item[3,3] {{null, GoldIgnot.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // GOLD SWORD RECIPE
            Recipe goldSwordRecipe = new Recipe((Craft) GoldSword.Get(), new Item[3,3] {{null, GoldIgnot.Get(), null}, 
                                                                {null, GoldIgnot.Get(), null},
                                                                {null, Stick.Get(), null}});

            //ADD GOLD TOOLS RECIPES TO ARRAY                                                   
            recipes.Add(goldAxeRecipe);
            recipes.Add(goldHoeRecipe);
            recipes.Add(goldPickAxeRecipe);
            recipes.Add(goldShovelRecipe);
            recipes.Add(goldSwordRecipe);

            // ! DIAMOND TOOLS RECIPES
            // GOLD AXE RECIPE
            Recipe diamondAxeRecipe = new Recipe((Craft) DiamondAxe.Get(), new Item[3,3] {{DiamondIgnot.Get(), DiamondIgnot.Get(), null}, 
                                                                {DiamondIgnot.Get(), Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // DIAMOND HOE RECIPE
            Recipe diamondHoeRecipe = new Recipe((Craft) DiamondHoe.Get(), new Item[3,3] {{DiamondIgnot.Get(), DiamondIgnot.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // DIAMOND PICK AXE RECIPE
            Recipe diamondPickAxeRecipe = new Recipe((Craft) DiamondPickAxe.Get(), new Item[3,3] {{DiamondIgnot.Get(), DiamondIgnot.Get(), DiamondIgnot.Get()}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});                                                                                                      

            // DIAMOND SHOVEL RECIPE
            Recipe diamondShovelRecipe = new Recipe((Craft) DiamondShovel.Get(), new Item[3,3] {{null, DiamondIgnot.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Stick.Get(), null}});

            // DIAMOND SWORD RECIPE
            Recipe diamondSwordRecipe = new Recipe((Craft) DiamondSword.Get(), new Item[3,3] {{null, DiamondIgnot.Get(), null}, 
                                                                {null, DiamondIgnot.Get(), null},
                                                                {null, Stick.Get(), null}});

            //ADD DIAMOND TOOLS RECIPES TO ARRAY                                                   
            recipes.Add(diamondAxeRecipe);
            recipes.Add(diamondHoeRecipe);
            recipes.Add(diamondPickAxeRecipe);
            recipes.Add(diamondShovelRecipe);
            recipes.Add(diamondSwordRecipe);

            // ! ITEMS RECIPES
            // ARROW RECIPE
            Recipe arrowRecipe = new Recipe((Craft) Arrow.Get(), new Item[3,3] {{null, Flint.Get(), null}, 
                                                                {null, Stick.Get(), null},
                                                                {null, Feather.Get(), null}});

            // BED RECIPE
            Recipe bedRecipe = new Recipe((Craft) Bed.Get(), new Item[3,3] {{null, null, null}, 
                                                                {Wool.Get(), Wool.Get(), Wool.Get()},
                                                                {WoodPlank.Get(), WoodPlank.Get(), WoodPlank.Get()}});

            // BONE MEAL RECIPE
            Recipe boneMealRecipe = new Recipe((Craft) BoneMeal.Get(), new Item[3,3] {{null, null, null}, 
                                                                {null, Wool.Get(), null},
                                                                {null, null, null}});

            // BOW RECIPE
            Recipe bowRecipe = new Recipe((Craft) Bow.Get(), new Item[3,3] {{null, Stick.Get(), String.Get()}, 
                                                                {Stick.Get(), null, String.Get()},
                                                                {null, Stick.Get(), String.Get()}});

            // BREAD RECIPE
            Recipe breadRecipe = new Recipe((Craft) Bread.Get(), new Item[3,3] {{null, null, null}, 
                                                                {Wheat.Get(), Wheat.Get(), Wheat.Get()},
                                                                {null, null, null}});

            // CHEST RECIPE
            Recipe chestRecipe = new Recipe((Craft) Chest.Get(), new Item[3,3] {{WoodPlank.Get(), WoodPlank.Get(), WoodPlank.Get()}, 
                                                                {WoodPlank.Get(), null, WoodPlank.Get()},
                                                                {WoodPlank.Get(), WoodPlank.Get(), WoodPlank.Get()}});

            // COMPASS RECIPE
            Recipe compassRecipe = new Recipe((Craft) Compass.Get(), new Item[3,3] {{null, IronIgnot.Get(), null}, 
                                                                {IronIgnot.Get(), RedstoneDust.Get(), IronIgnot.Get()},
                                                                {null, IronIgnot.Get(), null}});

            // CRAFT TABLE RECIPE
            Recipe craftTableRecipe = new Recipe((Craft) CraftTable.Get(), new Item[3,3] {{null, null, null}, 
                                                                {WoodPlank.Get(), WoodPlank.Get(), null},
                                                                {WoodPlank.Get(), WoodPlank.Get(), null}});

            // DOOR RECIPE
            Recipe doorRecipe = new Recipe((Craft) Door.Get(), new Item[3,3] {{WoodPlank.Get(), WoodPlank.Get(), null}, 
                                                                {WoodPlank.Get(), WoodPlank.Get(), null},
                                                                {WoodPlank.Get(), WoodPlank.Get(), null}});
            
            // FISHING ROD RECIPE
            Recipe fishingRodRecipe = new Recipe((Craft) FishingRod.Get(), new Item[3,3] {{null, null, Stick.Get()}, 
                                                                {null, Stick.Get(), String.Get()},
                                                                {Stick.Get(), null, String.Get()}});
            
            // FLETCHING TABLE RECIPE
            Recipe fletchingTableRecipe = new Recipe((Craft) FletchingTable.Get(), new Item[3,3] {{Flint.Get(), Flint.Get(), null}, 
                                                                {WoodPlank.Get(), WoodPlank.Get(), null},
                                                                {WoodPlank.Get(), WoodPlank.Get(), null}});
            
            // FLINT AND STEEL RECIPE
            Recipe flintSteelRecipe = new Recipe((Craft) FlintSteel.Get(), new Item[3,3] {{null, null, null}, 
                                                                {IronIgnot.Get(), Flint.Get(), null},
                                                                {null, null, null}});
            
            // FURNACE RECIPE
            Recipe furnaceRecipe = new Recipe((Craft) FurnaceItem.Get(), new Item[3,3] {{Cobblestone.Get(), Cobblestone.Get(), Cobblestone.Get()}, 
                                                                {Cobblestone.Get(), null, Cobblestone.Get()},
                                                                {Cobblestone.Get(), Cobblestone.Get(), Cobblestone.Get()}});
            
            // GLASS BLOCK RECIPE
            Recipe glassBlockRecipe = new Recipe((Craft) GlassBlock.Get(), new Item[3,3] {{null, null, null}, 
                                                                {null, null, null},
                                                                {Sand.Get(), null, null}});

            // GOLDEN APPLE RECIPE
            Recipe goldenAppleRecipe = new Recipe((Craft) GoldenApple.Get(), new Item[3,3] {{GoldIgnot.Get(), GoldIgnot.Get(), GoldIgnot.Get()}, 
                                                                {GoldIgnot.Get(), Apple.Get(), GoldIgnot.Get()},
                                                                {GoldIgnot.Get(), GoldIgnot.Get(), GoldIgnot.Get()}});

            // HAY BALE RECIPE
            Recipe hayBaleRecipe = new Recipe((Craft) HayBale.Get(), new Item[3,3] {{Wheat.Get(), Wheat.Get(), Wheat.Get()}, 
                                                                {Wheat.Get(), Wheat.Get(), Wheat.Get()},
                                                                {Wheat.Get(), Wheat.Get(), Wheat.Get()}});

            // ITEM FRAME RECIPE
            Recipe itemFrameRecipe = new Recipe((Craft) ItemFrame.Get(), new Item[3,3] {{Stick.Get(), Stick.Get(), Stick.Get()}, 
                                                                {Stick.Get(), Leather.Get(), Stick.Get()},
                                                                {Stick.Get(), Stick.Get(), Stick.Get()}});
            
            //ADD ITEMS RECIPES TO ARRAY 
            recipes.Add(arrowRecipe);
            recipes.Add(bedRecipe);
            recipes.Add(boneMealRecipe);
            recipes.Add(bowRecipe);
            recipes.Add(breadRecipe);
            recipes.Add(chestRecipe);
            recipes.Add(compassRecipe);
            recipes.Add(craftTableRecipe);
            recipes.Add(doorRecipe);
            recipes.Add(fishingRodRecipe);
            recipes.Add(fletchingTableRecipe);
            recipes.Add(flintSteelRecipe);
            recipes.Add(furnaceRecipe);
            recipes.Add(glassBlockRecipe);
            recipes.Add(goldenAppleRecipe);
            recipes.Add(hayBaleRecipe);
            recipes.Add(itemFrameRecipe);

        } 

        public static ArrayList Recipes
        {
            get
            {
                return recipes;
            }
        }
    }
}
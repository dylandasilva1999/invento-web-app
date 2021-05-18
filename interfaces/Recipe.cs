using System;
using System.Collections.Generic;

namespace invento_web_app
{
    class Recipe
    {
        private Basic[,] basicInputs;
        private Food[,] foodInputs;
        private Misc[,] miscInputs;
        private Rare[,] rareInputs;
        private Craft result;

        public Recipe(Craft newResult, Basic[,] newBasicInputs, Food[,] newFoodInputs, Misc[,] newMiscInputs, Rare[,] newRareInputs)
        {
            basicInputs = newBasicInputs;
            foodInputs = newFoodInputs;
            miscInputs = newMiscInputs;
            rareInputs = newRareInputs;
            result = newResult;
            result.SetRecipes(this);
        }

        public Basic[,] BasicInputs
        {
            get
            {
                return basicInputs;
            }
        }
        public Food[,] FoodInputs
        {
            get
            {
                return foodInputs;
            }
        }
        public Misc[,] MiscInputs
        {
            get
            {
                return miscInputs;
            }
        }
        public Rare[,] RareInputs
        {
            get
            {
                return rareInputs;
            }
        }

        public Basic BasicResult
        {
            get
            {
                return (Basic) result;
            }
        }
        public Food FoodResult
        {
            get
            {
                return (Food) result;
            }
        }
        public Misc MiscResult
        {
            get
            {
                return (Misc) result;
            }
        }
        public Rare RareResult
        {
            get
            {
                return (Rare) result;
            }
        }

        public bool IsViable()
        {
            var map = new Dictionary<string, int>();

            //Check through each resource item in the Basic Class
            foreach (Basic curBasicBlock in basicInputs)
            {
                if (curBasicBlock != null)
                {
                    int count;
                    if (map.TryGetValue(curBasicBlock.BasicBlockType, out count))
                    {
                        map[curBasicBlock.BasicBlockType] += 1;
                    }
                    else
                    {
                        map.Add(curBasicBlock.BasicBlockType,1);
                    }
                }
            }

            //Check through each resource item in the Food Class
            foreach (Food curFoodBlock in foodInputs)
            {
                if (curFoodBlock != null)
                {
                    int count;
                    if (map.TryGetValue(curFoodBlock.FoodBlockType, out count))
                    {
                        map[curFoodBlock.FoodBlockType] += 1;
                    }
                    else
                    {
                        map.Add(curFoodBlock.FoodBlockType,1);
                    }
                }
            }

            //Check through each resource item in the Misc Class
            foreach (Misc curMiscBlock in miscInputs)
            {
                if (curMiscBlock != null)
                {
                    int count;
                    if (map.TryGetValue(curMiscBlock.MiscBlockType, out count))
                    {
                        map[curMiscBlock.MiscBlockType] += 1;
                    }
                    else
                    {
                        map.Add(curMiscBlock.MiscBlockType,1);
                    }
                }
            }

            //Check through each resource item in the Rare Class
            foreach (Rare curRareBlock in rareInputs)
            {
                if (curRareBlock != null)
                {
                    int count;
                    if (map.TryGetValue(curRareBlock.RareBlockType, out count))
                    {
                        map[curRareBlock.RareBlockType] += 1;
                    }
                    else
                    {
                        map.Add(curRareBlock.RareBlockType,1);
                    }
                }
            }

            bool result = true;
            foreach (var pair in map)
            {
                if (pair.Value > Inventory.GetCount(pair.Key))
                    result = false;
            }

            return result;
        }
    }
}
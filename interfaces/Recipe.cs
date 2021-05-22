using System;
using System.Collections.Generic;

namespace invento_web_app
{
    class Recipe
    {
        private Item[,] inputs;
        private Craft result;

        public Recipe(Craft newResult, Item[,] newInputs)
        {
            inputs = newInputs;
            result = newResult;
            result.SetRecipe(this);
        }

        public Item[,] Inputs
        {
            get
            {
                return inputs;
            }
        }

        public Item Result
        {
            get
            {
                return (Item) result;
            }
        }

        public bool IsViable()
        {
            var map = new Dictionary<string, int>();

            //Check through each resource item in the Basic Class
            foreach (Item curItem in inputs)
            {
                if (curItem != null)
                {
                    int count;
                    if (map.TryGetValue(curItem.BlockType, out count))
                    {
                        map[curItem.BlockType] += 1;
                    }
                    else
                    {
                        map.Add(curItem.BlockType,1);
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
using System;
using System.Collections.Generic;

namespace invento_web_app
{
    class Recipe
    {
        private Basic[,] inputs;
        private Craft result;

        public Recipe(Craft newResult, Basic[,] newInputs)
        {
            inputs = newInputs;
            result = newResult;
            result.SetRecipes(this);
        }

        public Basic[,] Inputs
        {
            get
            {
                return inputs;
            }
        }

        public Basic Result
        {
            get
            {
                return (Basic) result;
            }
        }

        public bool IsViable()
        {
            var map = new Dictionary<string, int>();

            foreach (Basic curBlock in inputs)
            {
                if (curBlock != null)
                {
                    int count;
                    if (map.TryGetValue(curBlock.BasicBlockType, out count))
                    {
                        map[curBlock.BasicBlockType] += 1;
                    }
                    else
                    {
                        map.Add(curBlock.BasicBlockType,1);
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
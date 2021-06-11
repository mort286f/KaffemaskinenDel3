using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffemaskinenDel1
{
    class LiquidContainer
    {
        public enum liquids { water = 1, }

        public string PourLiquid(liquids liquid)
        {
            if (liquid.Equals(liquids.water))
            {
                return "Adding water to container";
            }
            else
            {
                return "Invalid liquid inserted";
            }
        }
    }
}

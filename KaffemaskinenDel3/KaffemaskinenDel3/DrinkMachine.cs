using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffemaskinenDel1
{
    class DrinkMachine : Machine
    {
        public override string Start()
        {
            return "DrinkMachine starting..";
        }
        public override string Stop()
        {
            return "DrinkMachine shutting down..";
        }

        public string MakeXDrinks(int drinkCount, IngredientContainer.ingredients ingredient)
        {
            string output = "";
            if (ingredient.Equals(IngredientContainer.ingredients.espresso))
            {
                for (int i = 0; i < drinkCount; i++)
                {
                    output += $"Making drink {i+1}\n";

                }
            }
            else
            {
                return output += $"Making {drinkCount} drinks";
            }
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace KaffemaskinenDel1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instances for the program
            DrinkMachine dm = new DrinkMachine();
            IngredientContainer ingContainer = new IngredientContainer();
            LiquidContainer liqContainer = new LiquidContainer();

            Console.WriteLine(dm.Start());
            Thread.Sleep(1000);
            Console.WriteLine("How many drinks do you wish to make?");
            int drinkCount = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine("What kind of drink do you want to make?");
            Console.WriteLine("(1) Coffee");
            Console.WriteLine("(2) Tea");
            Console.WriteLine("(3) Espresso");
            int drinkTypeInput = int.Parse(Console.ReadLine());
            switch (drinkTypeInput)
            {
                case 1:
                    Console.WriteLine(ingContainer.FillIngredients(IngredientContainer.ingredients.coffee));
                    break;
                case 2:
                    Console.WriteLine(ingContainer.FillIngredients(IngredientContainer.ingredients.tea));
                    break;
                case 3:
                    Console.WriteLine(ingContainer.FillIngredients(IngredientContainer.ingredients.espresso));
                    break;
                default:
                    break;
            }
            Console.WriteLine(ingContainer.FillIngredients(IngredientContainer.ingredients.coffee));
            Thread.Sleep(2000);
            Console.WriteLine(liqContainer.PourLiquid(LiquidContainer.liquids.water));
            Console.WriteLine(dm.MakeXDrinks(drinkCount,(IngredientContainer.ingredients)drinkTypeInput));
            Thread.Sleep(2000);
            Console.WriteLine(dm.Stop());

            Console.Read();
        }
    }
}

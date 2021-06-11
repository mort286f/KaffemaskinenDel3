using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffemaskinenDel1
{
    class IngredientContainer
    {
        public enum ingredients { coffee = 1, tea = 2, espresso = 3,}

        public string FillIngredients(ingredients ingredient)
        {
            if (ingredient.Equals(ingredients.coffee))
            {
                return "Filling ingredient container with coffee\n" +
                       "Inserting coffee filter";
            }
            if (ingredient.Equals(ingredients.tea))
            {
                return "Inserting tea into container";
            }
            if (ingredient.Equals(ingredients.espresso))
            {
                return "Filling ingredient container with espresso powder";
            }
            else
            {
                return "Invalid ingredient inserted. Maybe it was not implented yet, or perhaps you meant another one?";
            }
        }
    }
}

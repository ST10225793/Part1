using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaneleRecipeApp
{
    internal class Ingredient
    {
        public string Name { get; }
        public int Quantity { get; }
        public string UnitOfMeasurement { get; }
        public int Calories { get; }
        public string FoodGroup { get; }

        public Ingredient(string name, int quantity, string unitOfMeasurement, int calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            UnitOfMeasurement = unitOfMeasurement;
            Calories = calories;
            FoodGroup = foodGroup;
        }
    }
}

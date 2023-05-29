using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaneleRecipeApp
{
    internal class Recipe
    {
        public string Name { get; }
        public List<Ingredient> Ingredients { get; }

        public Recipe(string name, List<Ingredient> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaneleRecipeApp
{
    internal class RecipeDetails
    {
        private static String RecipeName;
        private static int NumofIngredients;
        private static String[] IngrName;
        private static int[] IngrQuantity;
        private static String[] UnitofMeasurement;
        private static int NumofSteps;
        private static String[] StepDescription;

        public String DisplayMenu(int menu)
        {
            //Display menu method created so that program continues to run after user is doe with an entry
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t" + "Please select one of the following menu items: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(1) Enter details of recipe");
            Console.WriteLine("(2) Display full recipe");
            Console.WriteLine("(3) Change recipe scaling");
            Console.WriteLine("(4) Reset quatities to original values");
            Console.WriteLine("(5) Clear data to enter new recipe");
            Console.WriteLine("");
            Console.WriteLine("Make a choice");
            menu = Convert.ToInt32(Console.ReadLine());
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaneleRecipeApp
{
    internal class Program
    {
        static int menu;
        private static String RecipeName;
        private static int NumofIngredients;
        private static String[] IngrName;
        private static int[] IngrQuantity;
        private static String[] UnitofMeasurement;
        private static int NumofSteps;
        private static String[] StepDescription;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to Sanele's Recipe App <3");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Please select one of the following menu items: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(1) Enter details of recipe");
            Console.WriteLine("(2) Display full recipe");
            Console.WriteLine("(3) Change recipe scaling");
            Console.WriteLine("(4) Reset quatities to original values");
            Console.WriteLine("(5) Clear data to enter new recipe");
            Console.WriteLine("");
            Console.WriteLine("Make a choice");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
    }
}

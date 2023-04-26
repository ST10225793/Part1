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
            Console.WriteLine("\t" + "\t" + "Welcome to Sanele's Recipe App <3");

            Console.WriteLine();

            do
            {
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
                if (menu == 1)
                {
                   RecipeDetails.StoreRecipe(); 
                }
                if(menu == 2)
                {

                }
                if(menu == 3)
                {

                }
                if(menu == 4)
                {

                }
                if(menu == 5)
                {

                }
                else if (menu == 6)
                {
                    Environment.Exit(0);
                }

            } while(true);
        }
    }
}

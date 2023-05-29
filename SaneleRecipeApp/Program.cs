using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SaneleRecipeApp.RecipeDetails;

namespace SaneleRecipeApp
{
    internal class Program
    {
        static int menu;
        

        public static RecipeExceededCaloriesHandler RecipeExceededCaloriesEventHandler { get; private set; }

        //public delegate void RecipeExceededCaloriesHandler(string recipeName, int totalCalories);
        // public static event RecipeExceededCaloriesHandler RecipeExceededCaloriesEvent;
        static void Main(string[] args)
        {
            RecipeDetails obj = new RecipeDetails(); 

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t" + "\t" + "Welcome to Sanele's Recipe App <3");

            Console.WriteLine();
            RecipeDetails.RecipeExceededCaloriesEvent += RecipeExceededCaloriesEventHandler;

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t" + "Please select one of the following menu items: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("(1) Enter details of recipe");
                Console.WriteLine("(2) Change recipe scaling");
                Console.WriteLine("(3) Reset quatities to original values");
                Console.WriteLine("(4) Display list of recipes");
                Console.WriteLine("(5) Display recipe details");
                Console.WriteLine("(6) Clear data to enter new recipe");
                Console.WriteLine("");
                Console.WriteLine("Make a choice");
                Console.WriteLine();

                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                   RecipeDetails.StoreRecipe(); 
                }
                if(menu == 2)
                {
                    RecipeDetails.ScalingQuantity();
                }
                if(menu == 3)
                {
                    RecipeDetails.resetQuantityValues();
                }
                if (menu == 4)
                {
                    RecipeDetails.DisplayList();

                }
                if (menu == 5)
                {
                    RecipeDetails.DisplayRecipe();

                }
                if (menu == 6)
                {
                    RecipeDetails.Clear();

                }
                else if (menu == 7)
                {
                    Environment.Exit(0);
                }

            } while(true);
        }
    }
}

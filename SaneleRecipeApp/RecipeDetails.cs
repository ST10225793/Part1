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

       
        public static void StoreRecipe()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter name of recipe: ");
            RecipeName = Console.ReadLine();
            Console.WriteLine("Recipe Name: " + RecipeName ) ;
            Console.WriteLine("Enter number of ingredients");
            NumofIngredients = Convert.ToInt32(Console.ReadLine());
            IngrName = new string[NumofIngredients];
            IngrQuantity = new int[NumofIngredients];
            UnitofMeasurement = new string[NumofIngredients];

            for (int i = 0; i < NumofIngredients; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingredient details");
                Console.WriteLine($"Ingredient no.{i + 1}");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Enter name of ingredient");
                IngrName[i] = Console.ReadLine();
                Console.WriteLine("Enter quantity of ingredient");
                IngrQuantity[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter unit of measurement");
                UnitofMeasurement[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Enter number of steps needed for this recipe");
            NumofSteps = Convert.ToInt32(Console.ReadLine());
            StepDescription = new String[NumofSteps];
            for (int j = 0; j < NumofSteps; j++)
            {
                Console.WriteLine($"Enter the description for each step {j + 1}");
                StepDescription[j] = Console.ReadLine();

            }
        }
    }
}

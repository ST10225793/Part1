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
        private static String IngrName;
        private static int IngrQuantity;
        private static String UnitofMeasurement;
        private static int NumofSteps;
        private static String StepDescription;
        private static double scaledQuantity;
        private static int Calories;
        private static String FoodGroup;

        

        public static void StoreRecipe()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter name of recipe: ");
            RecipeName = Console.ReadLine();

            Console.WriteLine("Recipe Name: " + RecipeName ) ;

            // Prompt the user to enter ingredient details
            Console.WriteLine("Enter number of ingredients");
            NumofIngredients = Convert.ToInt32(Console.ReadLine());
            List<Ingredient> ingredients = new List<Ingredient>();
            

            for (int i = 0; i < NumofIngredients; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t" + "\t" + "Ingredient details for recipe " + RecipeName);
                Console.WriteLine();
                Console.WriteLine($"Ingredient no.{i + 1}");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Enter name of ingredient");
                IngrName = Console.ReadLine();

                Console.WriteLine("Enter quantity of ingredient");
                IngrQuantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter unit of measurement");
                UnitofMeasurement = Console.ReadLine();

                Console.WriteLine("Enter number of calories");
                Calories = Convert.ToInt32(Console.ReadLine()) ;

                Console.WriteLine("Enter food group");
                FoodGroup = Console.ReadLine();

                // Create an Ingredient object with the entered details
                Ingredient ingredient = new Ingredient(IngrName, IngrQuantity, UnitofMeasurement, Calories, FoodGroup);
                ingredients.Add( ingredient );
            }
            Console.WriteLine();
            Console.WriteLine("Enter number of steps needed for this recipe");
            NumofSteps = Convert.ToInt32(Console.ReadLine());
           
            for (int j = 0; j < NumofSteps; j++)
            {
                Console.WriteLine($"Enter the description for step {j + 1}");
                StepDescription = Console.ReadLine();
                Console.WriteLine();

            }
            Recipe recipe = new Recipe(RecipeName, ingredients);
            recipes.Add( recipe );

            int totalCalories = ingredients.Sum(i => i.Calories);
            if (totalCalories > 300)
            {
                RecipeExceededCaloriesEvent?.Invoke(RecipeName, totalCalories);
            }

           
            Console.WriteLine();
            Console.WriteLine("Recipe strored successfully!");
            Console.WriteLine();
        }

        public static void DisplayList()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tRecipes List:");
            Console.WriteLine();

            List<Recipe> sortedRecipes = recipes.OrderBy(r => r.Name).ToList();

            foreach (Recipe recipe in sortedRecipes)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\tRecipe Name: {recipe.Name}");

                foreach (Ingredient ingredient in recipe.Ingredients)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ingredient Detail");
                    Console.WriteLine($"Ingredient Name: {ingredient.Name}");
                    Console.WriteLine($"Ingredient Quantity: {ingredient.Quantity} {ingredient.UnitOfMeasurement}");
                    Console.WriteLine($"Calories: {ingredient.Calories}");
                    Console.WriteLine($"Food Group: {ingredient.FoodGroup}");
                }
                for (int k = 0; k < NumofSteps; k++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Step {k + 1}:" + StepDescription);
                }

                Console.WriteLine();
            }
        }




        public static void ScalingQuantity()
        {
            int scale;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press (1) if you want to use a scale factor of 0.5");
            Console.WriteLine("Press (2) if you want to use a scale factor of 2");
            Console.WriteLine("Press (3) if you want to use a scale factor of 3");
            Console.WriteLine("Make a choice");
            scale = Convert.ToInt32(Console.ReadLine());
            while(!int.TryParse(Console.ReadLine(), out scale))
            {
                Console.WriteLine("Invalid input. Please enter a valid choice");
                Console.WriteLine("Make a choice");
            }
            
            Console.WriteLine();
            if (scale == 1)
            {
                for (int m = 0; m < NumofIngredients; m++)
                {
                    scaledQuantity = IngrQuantity * 0.5;
                   Console.WriteLine("New ingredient quantity: " + scaledQuantity + " " + UnitofMeasurement +
                        " of" + IngrName);
                }
            }

            else if (scale == 2)
            {
                for (int m = 0; m < NumofIngredients; m++)
                {
                    scaledQuantity = IngrQuantity * 2;
                    Console.WriteLine("New ingredient quantity: " + scaledQuantity + " " + UnitofMeasurement +
                        " of" + IngrName);
                }
            }

            else if (scale == 3)
            {
                for (int m = 0; m < NumofIngredients; m++)
                {
                    scaledQuantity = IngrQuantity * 3;
                    Console.WriteLine("New ingredient quantity: " + scaledQuantity + " " + UnitofMeasurement + 
                        " of" + IngrName);
                }
            }
            Console.WriteLine();
        }
        public static void resetQuantityValues()
        {
            int scale;
            for (int n = 0; n < NumofIngredients; n++)
            {

                Console.WriteLine("Press (1) if you want to reduce the quantity scale factor of 0.5");
                Console.WriteLine("Press (2) if you want to  reduce the quantity a scale factor of 2");
                Console.WriteLine("Press (3) if you want to  reduce the quantity a scale factor of 3");
                Console.WriteLine("Make a choice");
                scale = Convert.ToInt32(Console.ReadLine());
                

                Console.WriteLine();
                if (scale == 1)
                {
                    for (int m = 0; m < NumofIngredients; m++)
                    {
                        scaledQuantity = IngrQuantity / 0.5;
                        //IngrQuantity[m] = IngrQuantity[m] * 0.5;
                        Console.WriteLine("Original quantity value of " + IngrName + ":"
                   + IngrQuantity + " " + UnitofMeasurement);
                    }
                }

                else if (scale == 2)
                {
                    for (int m = 0; m < NumofIngredients; m++)
                    {
                        scaledQuantity = IngrQuantity / 2;
                        //IngrQuantity[m] = IngrQuantity[m] * 2;
                        Console.WriteLine("Original quantity value of " + IngrName + ":"
                   + IngrQuantity + " " + UnitofMeasurement);
                    }
                }

                else if (scale == 3)
                {
                    for (int m = 0; m < NumofIngredients; m++)
                    {
                        scaledQuantity = IngrQuantity / 3;
                        //IngrQuantity[m] = IngrQuantity[m] * 3;
                        Console.WriteLine("Original quantity value of " + IngrName + ":"
                    + IngrQuantity + " " + UnitofMeasurement);
                    }


                }
                Console.WriteLine();
            }

        }
        public static void Clear()
        {
            recipes.Clear();
            Console.WriteLine("Code cleared, Enter new recipe");
        }

    }


    }


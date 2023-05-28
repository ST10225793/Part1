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
        private static double scaledQuantity;


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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t" + "\t" + "Ingredient details");
                Console.WriteLine();
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
                Console.WriteLine($"Enter the description for step {j + 1}");
                StepDescription[j] = Console.ReadLine();
                Console.WriteLine();

            }
        }

        public static void DisplayRecipe()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t" + "Recipe Name: " + RecipeName);
            for (int l = 0; l < NumofIngredients; l++) 
            { 
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Ingredient Detail " + "\n" + "Ingredient Name: " + IngrName[l] + "\n"
                + "Ingredient Quantity: " + IngrQuantity[l] + "\n" + "Unit of measurement: " + UnitofMeasurement[l]);
            }
            for(int k = 0; k < NumofSteps; k++)
            {
                Console.WriteLine();
                Console.WriteLine($"Step {k + 1}:" + StepDescription[k]);
            }
            Console.WriteLine();
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
            //int fact1 = 1/2, fact2 = 2, fact3 = 3;
            
            Console.WriteLine();
            if (scale == 1)
            {
                for (int m = 0; m < NumofIngredients; m++)
                {
                    scaledQuantity = IngrQuantity[m] * 0.5;
                    //IngrQuantity[m] = IngrQuantity[m] * 0.5;
                   Console.WriteLine("New ingredient quantity: " + scaledQuantity + " " + UnitofMeasurement[m] +
                        " of" + IngrName[m]);
                }
            }

            else if (scale == 2)
            {
                for (int m = 0; m < NumofIngredients; m++)
                {
                    scaledQuantity = IngrQuantity[m] * 2;
                    //IngrQuantity[m] = IngrQuantity[m] * 2;
                    Console.WriteLine("New ingredient quantity: " + scaledQuantity + " " + UnitofMeasurement[m] +
                        " of" + IngrName[m]);
                }
            }

            else if (scale == 3)
            {
                for (int m = 0; m < NumofIngredients; m++)
                {
                    scaledQuantity = IngrQuantity[m] * 3;
                    //IngrQuantity[m] = IngrQuantity[m] * 3;
                    Console.WriteLine("New ingredient quantity: " + scaledQuantity + " " + UnitofMeasurement[m] + 
                        " of" + IngrName[m]);
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
                //int fact1 = 1/2, fact2 = 2, fact3 = 3;

                Console.WriteLine();
                if (scale == 1)
                {
                    for (int m = 0; m < NumofIngredients; m++)
                    {
                        scaledQuantity = IngrQuantity[m] / 0.5;
                        //IngrQuantity[m] = IngrQuantity[m] * 0.5;
                        Console.WriteLine("Original quantity value of " + IngrName[n] + ":"
                   + IngrQuantity[n] + " " + UnitofMeasurement[n]);
                    }
                }

                else if (scale == 2)
                {
                    for (int m = 0; m < NumofIngredients; m++)
                    {
                        scaledQuantity = IngrQuantity[m] / 2;
                        //IngrQuantity[m] = IngrQuantity[m] * 2;
                        Console.WriteLine("Original quantity value of " + IngrName[n] + ":"
                   + IngrQuantity[n] + " " + UnitofMeasurement[n]);
                    }
                }

                else if (scale == 3)
                {
                    for (int m = 0; m < NumofIngredients; m++)
                    {
                        scaledQuantity = IngrQuantity[m] / 3;
                        //IngrQuantity[m] = IngrQuantity[m] * 3;
                        Console.WriteLine("Original quantity value of " + IngrName[n] + ":"
                    + IngrQuantity[n] + " " + UnitofMeasurement[n]);
                    }


                }
                Console.WriteLine();
            }
        }
            public static void Clear(string[] IngrName, int[] IngrQuantity, string[] UnitofMeasurement, string[] StepDescription)
            {
                Array.Clear(IngrName, 0, IngrName.Length);
                Array.Clear(IngrQuantity, 0, IngrQuantity.Length);
                Array.Clear(UnitofMeasurement, 0, UnitofMeasurement.Length);
                Array.Clear(StepDescription, 0, StepDescription.Length);
                Console.WriteLine("Code cleared, Enter new recipe");


            }
        }


    }


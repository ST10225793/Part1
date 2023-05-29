using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SaneleRecipeApp;        // Import the main namespace of SaneleRecipeApp
using System.Collections.Generic;   // Import the namespace for using generic collections
using System.Linq;                  // Import the namespace for using LINQ


namespace UnitTestCaloriesProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateTotalCalories_CorrectCalculation()
        {
            // Arrange
            var recipe = new Recipe("Sample Recipe", new List<Ingredient>
            {
                new Ingredient("Ingredient 1 - Potato", 100, "large", 161, "Food Group Starch"),
                new Ingredient("Ingredient 2 - Egg", 200, "large", 155, "Food Group Protein"),
                new Ingredient("Ingredient 3 - Mayonnaise", 150, "Scoops", 680, "Food Group Fats and oils")
            });

            // Expected total calories: 161 + 155 + 680 = 996
            const int expectedTotalCalories = 996;

            // Act
            int actualTotalCalories = recipe.CalculateTotalCalories();

            // Assert
            Assert.AreEqual(expectedTotalCalories, actualTotalCalories, "Total calories are not calculated correctly.");
        }
    }
    }

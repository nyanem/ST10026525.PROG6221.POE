using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ST10026525.POE.PART1.recipeClass;

namespace ST10026525.POE.PART1
{
    internal class RecipeBook
    {
        //This method has been created for the input values
        public static recipeClass CreateNew()
        {

            Console.WriteLine("Enter the Name of your Recipe: ");
            string recipeName = Console.ReadLine();

            Console.WriteLine("How many Ingriedents does this Receipe need?: ");
            int numIngredients;
            if (!int.TryParse(Console.ReadLine(), out numIngredients) || numIngredients <= 0) {
                Console.WriteLine("Please enter a number for ingredients.");
                return null;
            }

            //Input values are being stores in a array 
            ingredientClass[] ingredients = new ingredientClass[numIngredients];
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Name:");
                string ingredientName = Console.ReadLine();
         

                Console.WriteLine("Quantity: ");
                double quantity;
                if (!double.TryParse(Console.ReadLine(), out quantity) || quantity <= 0) {
                    Console.WriteLine("Invalid quantity.");
                    return null;
                }

                Console.WriteLine("Unit:");
               string unit = Console.ReadLine();

                ingredients[i] = new ingredientClass(ingredientName, quantity, unit);
            } 
            
            Console.WriteLine("How many steps does this recipe have? ");
            int numSteps;
            if (!int.TryParse(Console.ReadLine(), out numSteps) || numSteps <= 0)
            {
                Console.WriteLine("Invalid input");
                return null;
            }
            //This arrays stores the steps for ingredients
            string[] steps = new string[numSteps];
            for (int i = 0; i < numSteps; i++) 
            { 
                Console.WriteLine("Enter step " + (i + 1) + ": ");
                steps[i] = Console.ReadLine();
            }
            return new recipeClass(recipeName, ingredients, steps);
        }
    }
}

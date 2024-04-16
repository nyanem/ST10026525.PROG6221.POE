using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10026525.POE.PART1
{
    internal class RecipeBook
    {
        public static recipeClass CreateNew() 
        {
            Console.WriteLine("Enter the Name of your Recipe: ");
            string recipeName = Console.ReadLine();

            Console.WriteLine("How many Ingriedents does this Receipe need?: ");
            int numIngredients = int.Parse(Console.ReadLine());
            ingredientClass[] ingredients = new ingredientClass[numIngredients];
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Name:");
               string ingredientName = Console.ReadLine();

                Console.WriteLine("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine("Unit:");
               string unit = Console.ReadLine();

                ingredients[i] = new ingredientClass(ingredientName, quantity, unit);
            }
        }
    }
}

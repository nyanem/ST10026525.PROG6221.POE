using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ST10026525.POE.PART1.Recipe;


namespace ST10026525.POE.PART1
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            List<recipeClass> recipes = new List<recipeClass>();
            List<stepsforRecipe> steps = new List<stepsforRecipe>();

            
            Console.WriteLine("How many Ingriedents does this Receipe need?:");
            int numIngredients = int.Parse(Console.ReadLine());
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter the name of the Ingredient and the Quantity you will need ({i+ 1}):");
                recipeClass details = new recipeClass();
                Console.WriteLine("Name:");
                details.Name = Console.ReadLine();

                Console.WriteLine("Quantity: ");
                details.Quantity = double.Parse(Console.ReadLine());

                Console.WriteLine("Unit:");
                details.Unit = Console.ReadLine();

                recipes.Add(details);
            }
            Console.WriteLine("Enter the number of Steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            for (int j = 0; 1 < numSteps; j++) {
                Console.WriteLine($"Enter description for step #{j + 1}: ");
                stepsforRecipe desc = new stepsforRecipe();
                Console.WriteLine("Description: ");
                desc.Description = Console.ReadLine();
                steps.Add(desc);
            }
            //Display the full recipe 
            Console.WriteLine("Recipe:");
            Console.WriteLine("Ingredients:");
            foreach (var recipe in recipes)
            {
                Console.WriteLine($"\t-{recipe.Quantity}{recipe.Unit} of {recipe.Name}");
            }
            Console.WriteLine("Steps:");
            for (int i = 0; < steps.Count; i++) {
                Console.WriteLine($"\tStep {i + 1}: {steps[i].Description}");
            }    
        }
    }
}

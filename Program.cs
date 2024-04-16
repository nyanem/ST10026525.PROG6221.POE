using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ST10026525.POE.PART1.ingredientClass;


namespace ST10026525.POE.PART1
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            //Object calls for recipe to be displayed 
            recipeClass recipe = RecipeBook.CreateNew();
            recipe.displayRecipe();

           

            List<recipeClass> recipes = new List<recipeClass>();
           // List<stepsforRecipe> steps = new List<stepsforRecipe>();

            
           
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

            //Function to scale Recipe 
            List<recipeClass> ScaleRecipe (List < recipeClass >
            orginalIngredients, double scalingFactor)
          { 
                List<recipeClass> scaledIngredients = new List<recipeClass>();

                foreach (var originalIngredient in orginalIngredients)
                {
                    recipeClass scaledRecipe = new recipeClass();
                    { 
                       Name = orginalIngredients.Name,
                       Quantity = orginalIngredients.Quantity * scalingFactor, 
                       Unit = originalIngredient.Unit
                    };
                    scaledIngredients.Add(scaledRecipe);
                }
            
          }
            //Function to reset the quantityies to the orginal values
            List <recipeClass> resetQuantities ( List<recipeClass> scaledIngredients, List <recipeClass> originalIngredients) { 
            for (int i = 0; i < scaledIngredients.Count; i++)
                {
                    scaledIngredients[i].Quantity = originalIngredients[i].Quantity;
                }
                return scaledIngredients;
            }
            Console.WriteLine("Would you like to reset the quantities to the orginal values? (Y/N)");
            string resetInput = Console.ReadLine();
            if (resetInput.ToLower() == "y") 
            {
                //Reset Values to quantities to the original values
                scaledIngredients = resetQuantities(scaledIngredients, recipes);

                //Display the recipe with orginal quantities 
                Console.WriteLine("Recipe with Original Quantities:");
            }
        }
    }
}

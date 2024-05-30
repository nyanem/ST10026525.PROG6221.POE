using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**/

namespace ST10026525.POE.PART1
{
    internal class recipeClass
    {
        // declaring variebles
        public string recipeName { get; set; }
        public ingredientClass[] Ingredients { get; set; }
        public string[] Steps { get; set; }
        // populating the varieble
        public recipeClass(string name, ingredientClass[] ingredients, string[] steps)
        {
            recipeName = name;
            Ingredients = ingredients;
            Steps = steps;
        }
        //This method displays the recipe on the console
        public void displayRecipe()
        {
            Console.WriteLine("Recipe for: " + recipeName);
            Console.WriteLine("Ingredents:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of  {ingredient.ingredientName}");
            }
            Console.WriteLine("Steps: ");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{(i + 1)}: " + Steps[i]);
            }

        }

        // This methods calculates the scale factors 
        public void scaleCalculator(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }
    }
}

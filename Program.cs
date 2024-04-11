using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10026525.POE.PART1
{
    internal class Program
    {
        public class recipeClass
        {
            //Declaring Variebles
            public string Name { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }
            public string Description { get; set; }

        }
        static void Main(string[] args)
        {
            List<recipeClass> recipes = new List<recipeClass>();

            Console.WriteLine("How many Ingreidents does this Receipe need?:");
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
            
        }
    }
}

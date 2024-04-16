using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ST10026525.POE.PART1.ingredientClass;
using static ST10026525.POE.PART1.recipeClass;


namespace ST10026525.POE.PART1
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            //Object calls for recipe to be displayed 
            recipeClass recipe = RecipeBook.CreateNew();
            if (recipe != null)
            {
                //creating a menue where user can choose what they wish to do with their reciper
                bool scaled = false;
                while (true)
                {
                    Console.WriteLine("Recipe Options:");
                    Console.WriteLine("1. Display Recipe");
                    Console.WriteLine("2. Scale Recipe");
                    Console.WriteLine("3. Exit");

                    Console.WriteLine("Choose number: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            recipe.displayRecipe();
                            break;
                        case "2":
                            if (!scaled)
                            {
                                Console.WriteLine("Would you like your recipe to be halfed(X0.5), doubled (x2) or tripled (x3): ");
                                double factor;
                                if (double.TryParse(Console.ReadLine(), out factor))
                                {
                                    recipe.scaleCalculator(factor);
                                    Console.WriteLine("Here are your new measurements!");
                                    scaled = true;
                                }
                                else
                                {
                                    Console.WriteLine("Error please try again");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Complete :)");
                            }
                            break;
                        case "3":
                            Console.WriteLine("Goodbye :)");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please eneter a number from 1 to 3");
                            break;
                    }
                }

            }
            else { Console.WriteLine("Failed :("); }
           
            Console.ReadKey();
        }
    }
}

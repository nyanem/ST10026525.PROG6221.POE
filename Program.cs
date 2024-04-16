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
            recipeClass recipe = null;


            //creating a menue where user can choose what they wish to do with their reciper
            bool scaled = false;
            double orginalFactor = 1.0;
            while (true)
            {
                Console.WriteLine("Recipe Options:");
                Console.WriteLine("1. Enter new Recipe");
                Console.WriteLine("2. Display Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset Ingredients");
                Console.WriteLine("5. Clear All Data");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Welcome to Sanele's Recipe book, what would you like to do?: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": //Enter new data 
                        recipe = RecipeBook.CreateNew();
                        scaled = false; //this is going to reset the scaled data 
                        break;
                    case "2":
                        if (recipe != null)
                        {
                            recipe.displayRecipe();
                        }
                        else
                        {
                            Console.WriteLine("Enter new recipe");
                        } break;

                    case "3":
                        if (recipe != null)
                        {
                            if (!scaled)
                            {
                                Console.WriteLine("Would you like to half (x0.5), double (x2) or triple your recipe (x3): ");
                                double factor;
                                if (double.TryParse(Console.ReadLine(), out factor))
                                {
                                    orginalFactor = factor;
                                    recipe.scaleCalculator(factor);
                                    Console.WriteLine("Recipe scaled successfully");
                                    scaled = true;
                                }
                                else
                                {
                                    Console.WriteLine("INVALID!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Done!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter a recipe");
                        }

                        break;
                    case "4":
                        if (scaled)
                        {
                            recipe.scaleCalculator(1.0 / orginalFactor);
                            Console.WriteLine("Quantities reset to original values");
                            scaled = false;
                        }
                        else 
                        { 
                            Console.WriteLine("Already done!");
                        }
                        break;
                        case "5":
                        recipe = null;
                        scaled = false;
                        Console.WriteLine("All data has been cleared");
                        break;
                        case "6":
                        Console.WriteLine("Goodbye ");
                        return;
                        default:
                        Console.WriteLine("Enter a number from the menu");
                        break;
                }

            }
            Console.ReadKey();
        } 
       
    }
  
}

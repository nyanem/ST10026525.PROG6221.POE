using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ST10026525.POE.PART1.ingredientClass;
using static ST10026525.POE.PART1.recipeClass;

/*PROGRAMING PORTFOLIO OF EVIDENCE FOR KHANYI MABUZA (ST10026525).The following project, is a recipe app for Lindiwe, which will allow a user to add 
 new recipes as well as remove them. With a few advanced features.
References 
1. W3Schools: https://www.w3schools.com/
2. Stack OverFlow:https://stackoverflow.com/questions/9239080/recipe-ingredients-database-in-entity-framework-asp-net-mvc */

namespace ST10026525.POE.PART1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Added a List Array to store multiple Recipes.
           List <recipeClass> recipe = new List <recipeClass> (); 
           recipeClass selectedRecipe = null;

            //creating a menue where user can choose what they wish to do with their reciper
            bool scaled = false;
            double orginalFactor = 1.0;

            while (true)
            {
                Console.WriteLine("Welcome to Sanele's Recipe book, what would you like to do?: ");
                Console.WriteLine("Recipe Options:");
                Console.WriteLine("1. Enter new Recipe");
                Console.WriteLine("2. Display all Recipes");
                Console.WriteLine("3. Select Recipe to scale");
                Console.WriteLine("4. Reset Ingredients");
                Console.WriteLine("5. Clear All Data");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": //Enter new data 
                       var  newrecipe = RecipeBook.CreateNew();
                        if (newrecipe != null)
                        {
                            recipe.Add(newrecipe);
                        }
                        break;
                    case "2":
                        if (recipe.Count > 0)
                        {
                            for (int i = 0; i <  recipe.Count; i++) 
                                {
                                Console.WriteLine($"{i + 1}. {recipe[i].recipeName}");
                            }
                        }
                        else
                        {
                            Console.WriteLine(" No recipes available. Please add a new recipe ");
                        }
                        break;
                        
                     

                    case "3":
                        if (recipe.Count > 0)
                        {
                            Console.WriteLine("Select a recipe number to scale:");
                            for (int i = 0; i < recipe.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {recipe[i].recipeName}");
                            }
                            if (int.TryParse(Console.ReadLine(), out int recipeIndex) && recipeIndex > 0 && recipeIndex <= recipes.Count)
                            {
                                selectedRecipe = recipe[recipeIndex - 1];
                                if (!scaled)
                                {
                                    Console.Write("Would you like to half (0.5), double (2), or triple your recipe (3): ");
                                    if (double.TryParse(Console.ReadLine(), out double factor))
                                    {
                                        selectedRecipe.scaleCalculator(factor);
                                        orginalFactor = factor;
                                        Console.WriteLine("Recipe scaled successfully.");
                                        scaled = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input! Please enter a valid number.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Recipe is already scaled.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid recipe number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No recipes available. Please add a new recipe.");
                        }
                        break;
                    case "4":
                        if (selectedRecipe != null && scaled)
                        {
                            selectedRecipe.scaleCalculator(1.0 / orginalFactor);
                            Console.WriteLine("Quantities reset to original values.");
                            scaled = false;
                        }
                        else
                        {
                            Console.WriteLine("No recipe selected or the recipe is already in its original state.");
                        }
                        break;
                    case "5":
                        recipes.Clear();
                        selectedRecipe = null;
                        scaled = false;
                        Console.WriteLine("All data has been cleared.");
                        break;
                    case "6":
                        Console.WriteLine("Goodbye! ");
                        return;
                    default:
                        Console.WriteLine("INVALID! PLease enter a number from the menu");
                        break;
                }

            }
        } 
       
    }
  
}

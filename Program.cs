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
            if (recipe != null )
            {
                recipe.displayRecipe();
            } else { Console.WriteLine("Failed to create Recipe.") ; }
           
            Console.ReadKey();
        }
    }
}

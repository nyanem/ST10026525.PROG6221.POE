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
        }
    }
}

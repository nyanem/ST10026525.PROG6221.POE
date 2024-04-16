﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ST10026525.POE.PART1
{
    internal class recipeClass
    {

        public string recipeName;
        public ingredientClass[] Ingredients { get; set; }
        public string[] Steps { get; set; }

        public recipeClass(string name, ingredientClass[] ingredients, string[] steps)
        {
            recipeName = name;
            Ingredients = ingredients;
            Steps = steps;
        }
        public void displayRecipe()
        {
            Console.WriteLine("Recipe for: " + recipeName);
            Console.WriteLine("Ingredents:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient.Quantity.ToString(), ingredient.Unit.ToString() + "of" + ingredient.ingredientName.ToString());
            }
            Console.WriteLine("Steps: ");
            for (int i = 0; i < Steps.Length; i++) { Console.WriteLine($"{(i + 1)}: " + Steps[i]); }

        }

        public void scaleCalculator(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }
    }
}

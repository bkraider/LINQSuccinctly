using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetRangeVariable_pg23
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] csvRecipes = {
                                     "milk,sugar,eggs",
                                     "flour,BUTTER,eggs",
                                     "vanilla,ChEEsE,oats"
                                    };
            var dairyQuery = from csvRecipe in csvRecipes
                             let ingredients = csvRecipe.Split(',')
                             from ingredient in ingredients
                             let uppercaseIngredient = ingredient.ToUpper()
                             where uppercaseIngredient == "MILK" || uppercaseIngredient == "BUTTER" || uppercaseIngredient == "CHEESE"
                             select uppercaseIngredient;
            foreach (var dairyIngredient in dairyQuery)
            {
                Console.WriteLine("{0} is dairy", dairyIngredient);
            }

            Console.ReadLine();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedQueryOperator_pg18
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredient[] ingredients = {
                                        new Ingredient {
                                        Name = "Sugar", Calories = 500
                                        },
                                        new Ingredient {
                                        Name = "Egg", Calories = 100
                                        },
                                        new Ingredient {
                                        Name = "Milk", Calories = 150
                                        },
                                        new Ingredient {
                                        Name = "Flour", Calories = 50
                                        },
                                        new Ingredient {
                                        Name = "Butter", Calories = 200
                                        }
                                    };


            IEnumerable<string> highCalorieIngredientNamesQuery = 
                ingredients
                .Where(x => x.Calories >= 150)
                .OrderBy(x => x.Name)
                .Select(x => x.Name);

            foreach (var ingredientName in highCalorieIngredientNamesQuery)
            {
                Console.WriteLine(ingredientName);
            }

            Console.ReadLine();
        }
    }

    class Ingredient
    {
        public string Name
        {
            get;
            set;
        }
        public int Calories
        {
            get;
            set;
        }
    }
}

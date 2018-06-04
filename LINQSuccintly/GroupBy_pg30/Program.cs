using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy_pg30
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
                                  Name = "Lard", Calories = 500
                                 },
                                 new Ingredient {
                                  Name = "Butter", Calories = 500
                                 },
                                 new Ingredient {
                                  Name = "Egg", Calories = 100
                                 },
                                 new Ingredient {
                                  Name = "Milk", Calories = 100
                                 },
                                 new Ingredient {
                                  Name = "Flour", Calories = 50
                                 },
                                 new Ingredient {
                                  Name = "Oats", Calories = 50
                                 }
                                };

            IEnumerable<IGrouping<int, Ingredient>> query = from i in ingredients group i by i.Calories;
            foreach (IGrouping<int, Ingredient> group in query)
            {
                Console.WriteLine("Ingredients with {0} calories", group.Key);
                foreach (Ingredient ingredient in group)
                {
                    Console.WriteLine(" - {0}", ingredient.Name);
                }
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

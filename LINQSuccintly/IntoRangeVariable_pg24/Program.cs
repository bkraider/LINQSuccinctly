using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoRangeVariable_pg24
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
            IEnumerable<Ingredient> highCalDairyQuery = from i in ingredients
                                                        select new
                                                        {
                                                            OriginalIngredient = i,
                                                            IsDairy = i.Name == "Milk" || i.Name == "Butter",
                                                            IsHighCalorie = i.Calories >= 150
                                                        }
            into temp
                                                        where temp.IsDairy && temp.IsHighCalorie
                                                        // cannot write "select i;" as into hides the previous range variable i 
                                                        select temp.OriginalIngredient;
            foreach (var ingredient in highCalDairyQuery)
            {
                Console.WriteLine(ingredient.Name);
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

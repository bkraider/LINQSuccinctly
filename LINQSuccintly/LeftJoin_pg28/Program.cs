using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftJoin_pg28
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe[] recipes = {
                              new Recipe {
                               Id = 1, Name = "Mashed Potato"
                              },
                              new Recipe {
                               Id = 2, Name = "Crispy Duck"
                              },
                              new Recipe {
                               Id = 3, Name = "Sachertorte"
                              }
                             };
                                        Review[] reviews = {
                              new Review {
                               RecipeId = 1, ReviewText = "Tasty!"
                              },
                              new Review {
                               RecipeId = 1, ReviewText = "Not nice :("
                              },
                              new Review {
                               RecipeId = 1, ReviewText = "Pretty good"
                              },
                              new Review {
                               RecipeId = 2, ReviewText = "Too hard"
                              },
                              new Review {
                               RecipeId = 2, ReviewText = "Loved it"
                              }
                             };

            var query = from recipe in recipes
                        join review in reviews on recipe.Id equals review.RecipeId
                        into reviewgroup
                        from rg in reviewgroup.DefaultIfEmpty()
                        select new // anonymous type 
                        {
                            RecipeName = recipe.Name,
                            RecipeReview = (rg == null ? "n/a" : rg.ReviewText)
                        };

            foreach (var item in query)
            {
                Console.WriteLine("{0} - {1}", item.RecipeName, item.RecipeReview);
            }

            Console.ReadLine();
        }
    }

    class Recipe
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
    }
    class Review
    {
        public int RecipeId
        {
            get;
            set;
        }
        public string ReviewText
        {
            get;
            set;
        }
    }
}

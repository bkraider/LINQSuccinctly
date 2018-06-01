using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToArrayOperator_pg15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = {
                                0,
                                1,
                                1,
                                2,
                                3,
                                5
                            };

            // Construct the query 
            IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x => x > 2).ToArray();

            // At this point the query has been executed because of the .ToArray() 
            // Change the first element of the input sequence 

            fibonacci[0] = 99;

            // Enumerate the results 
            foreach (var number in numbersGreaterThanTwoQuery)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}

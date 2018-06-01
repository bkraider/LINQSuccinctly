using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredExecution_pg14
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
            IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x => x > 2);
            // At this point the query has been created but not executed 
            // Change the first element of the input sequence 
            fibonacci[0] = 99;
            // Cause the query to be executed (enumerated) 
            foreach (var number in numbersGreaterThanTwoQuery)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}

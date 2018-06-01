using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSuccintly
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
            // Scalar return value 
            int numberOfElements = fibonacci.Count();
            Console.WriteLine("Count: {0}", numberOfElements);
            // Output sequence return value 
            IEnumerable<int> distinctNumbers = fibonacci.Distinct();
            Console.WriteLine("Elements in output sequence:");
            foreach (var number in distinctNumbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}

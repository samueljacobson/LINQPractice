using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 45, 78, 45, 2, 344, 2, 11 };
            
            //Select numbers greater than 6
            var filter = from x in numbers
                         where x > 6
                         select x;
            foreach (var result in filter)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine();

            //Select numbers with first digit of 1 and double (projection)
            var digitOne = from y in numbers
                           where y.ToString().StartsWith("1")
                           select y * 2;
            foreach (var result in digitOne)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine();

            //FizzBuzz using LINQ
            var values = Enumerable.Range(1, 100);

            var results = from n in values
                          select new    //anonymous type (instead of creating new class)
                          {
                              Number = n,
                              IsFizz = n % 3 == 0,
                              IsBuzz = n % 5 == 0,
                              IsFizzBuzz = n % 15 == 0
                          };

            foreach (var item in results)
            {
                if(item.IsFizzBuzz)
                    Console.WriteLine("FizzBuzz");
                if(item.IsBuzz)
                    Console.WriteLine("Buzz");
                if(item.IsFizz)
                    Console.WriteLine("Fizz");
                else Console.WriteLine(item.Number.ToString());
            }

            //FizzBuzz using LINQ and ternaries
        }
    }
}

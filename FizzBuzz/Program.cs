/* For each number from 1 to 1000 in order,
* print "Fizz" for the ones divisible by 3 (& not 5)
* print "Buzz" for the ones divisible by 5 (& not 3)
* print "Fizzbuzz" for the ones divisible by both 3 and 5
* print the number itself, for all the rest of the numbers
Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz. */

using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 0, buzz = 0, fizzbuzz = 0;

            for (int i = 1; i <= 1000; ++i)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ++fizzbuzz;
                    Console.WriteLine("Fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    ++fizz;
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    ++buzz;
                    Console.WriteLine("Buzz");
                }
                else Console.WriteLine(i.ToString());
            }

            Console.WriteLine("Fizz: {0}, Buzz: {1}, Fizzbuzz: {2}", fizz, buzz, fizzbuzz);
        }
    }
}

using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 0;
            int buzz = 0;
            int fizzBuzz = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    fizzBuzz += 1;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fizz += 1;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzz += 1;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Fizz {0} Buzz {1} FizzBuzz {2}", fizz, buzz, fizzBuzz);

        }
    }
}

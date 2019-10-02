using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(1000);
        }
        static void FizzBuzz(int number)
        {
            int fizz = 0;
            int buzz = 0;
            int fizzbuzz = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    fizz++;
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    buzz++;
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzbuzz++;
                    Console.WriteLine("FizzBuzz");
                }
                else
                    Console.WriteLine(i);
            }
            Console.WriteLine("We have " + fizz + " Fizz, " + buzz + " Buzz, and " + fizzbuzz + " FizzBuzz");
        }
    }
}

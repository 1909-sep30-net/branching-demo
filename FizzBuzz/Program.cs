using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizzCount = 0;
            int buzzCount = 0;
            int fizzBuzzCount = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    fizzCount++;
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    buzzCount++;
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzzCount++;
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Fizz count     = " + fizzCount);
                Console.WriteLine("Buzz count     = " + buzzCount);
                Console.WriteLine("FizzBuzz count = " + fizzBuzzCount);



            }
            Console.WriteLine("Hello World!");
        }
    }
}

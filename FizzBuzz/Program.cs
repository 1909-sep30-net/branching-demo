using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizzCount = 0;
            int buzzCount = 0;
            int fizzbuzzCount = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                    fizzCount++;
                } else
                if (i % 5 == 0 && i % 3 != 0){
                    Console.WriteLine("Buzz");
                    buzzCount++;
                } else
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                    fizzbuzzCount++;
                } else 
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"Number of Fizz: {fizzCount}\nNumber of Buzz: {buzzCount}\nNumber of Fizzbuzz: {fizzbuzzCount}");
        }
    }
}

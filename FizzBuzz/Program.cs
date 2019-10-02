using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizzbuzz = 0;
            int buzz = 0;
            int fizz = 0;

            for (int i = 1; i <= 1000; i++) {
                if (i % 15 == 0) {
                    Console.WriteLine("Fizzbuzz");
                    fizzbuzz++;
                } else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                    buzz++;
                } else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                    fizz++;
                } else {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("The number of fizz is: " + fizz);
            Console.WriteLine("The number of buzz is: " + buzz);
            Console.WriteLine("The number of fizzbuzz is: " + fizzbuzz);
        }
    }
}

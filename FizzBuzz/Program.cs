using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz_num = 0;
            int buzz_num = 0;
            int fizzbuzz_num = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if(i%3 == 0 && i%5 != 0)
                {
                    Console.WriteLine("Fizz");
                    fizz_num++;
                }
                else if(i%5 == 0 && i%3 != 0)
                {
                    Console.WriteLine("Buzz");
                    buzz_num++;
                }
                else if(i%5 == 0 && i%3 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                    fizzbuzz_num++;
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.WriteLine("\n");
            Console.WriteLine("Amount of \"Fizz\": " + fizz_num);
            Console.WriteLine("Amount of \"Buzz\": " + buzz_num);
            Console.WriteLine("Amount of \"FizzBuzz\": " + fizzbuzz_num);
        }
    }
}

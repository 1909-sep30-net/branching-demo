using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if(i%3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    Console.WriteLine(i);
                    a++;
                }
                else if( i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                    Console.WriteLine(i);
                    b++;
                }
                else if(i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    Console.WriteLine(i);
                    c++;
                }
                else
                    Console.WriteLine(i);
            }
            Console.WriteLine("There are " + a + " FizzBuzz numbers");
            Console.WriteLine("There are " + b + " Fizz numbers");
            Console.WriteLine("There are " + c + " Buzz numbers");
        }
    }
}

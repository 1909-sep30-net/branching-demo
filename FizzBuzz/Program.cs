using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int count_f = 0;
            int count_b = 0;
            int count_fb = 0;

            for ( int i = 1 ; i <= 1000 ; i++ ){
                if ( i % 15 == 0 ){
                    Console.WriteLine("Fizzbuzz");
                    count_fb++;
                } else if ( i % 5 == 0 ){
                    Console.WriteLine("Buzz");
                    count_b++;
                } else if ( i % 3 == 0 ){
                    Console.WriteLine("Fizz");
                    count_f++;
                } else {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Count of Fizz: " + count_f);
            Console.WriteLine("Count of Buzz: " + count_b);
            Console.WriteLine("Count of Fizzbuzz: " + count_fb);
        }
    }
}

//Tri
using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
                int Fizz = 0;
                int Buzz = 0;
                int Fizzbuzz = 0;
            for(int num = 0; num < 1000; num++)
            {


                //print Fizz for numbers divisible by 3, not 5
                if(num%3 == 0 && num%5 != 0){
                    Console.WriteLine("Fizz");
                    Fizz++;

                }
                //print Buzz for numbers divisible by 5, not 3
                else if(num%5 == 0 && num%3 != 0)
                {
                    Console.WriteLine("Buzz");
                    Buzz++;

                }
                //print Fizzbuzz for numbers divisble by 5 and 3
                else if(num%3 == 0 && num%5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                    Fizzbuzz++;

                }
                else
                {
                    System.Console.WriteLine(num);
                }


            }

            Console.WriteLine("Fizz = " + Fizz);
            Console.WriteLine("Buzz = " + Buzz);
            Console.WriteLine("Fizzbuzz = " + Fizzbuzz);
        }
    }
}

using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFizz = 0;
            int nBuzz = 0;
            int nFizzBuzz = 0;

            for(int n = 1 ; n <= 1000 ; n++)
            {
                if( (n%3 == 0) && (n%5 == 0) )
                {
                    Console.Write("FizzBuzz,");
                    nFizzBuzz++;
                }
                else if ( n%3 == 0)
                {
                    Console.Write("Fizz,");
                    nFizz++;
                }
                else if ( n%5 == 0)
                {
                    Console.Write("Buzz,");
                    nBuzz++;
                }
                else
                {
                    Console.Write(n.ToString() + ",");
                }
            }

            Console.Write($"\n\nCounts:\nFizz: {nFizz}\nBuzz: {nBuzz}\nFizzBuzz: {nFizzBuzz}\n");

        }
    }
}

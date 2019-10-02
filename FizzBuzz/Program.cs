using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizzCnt = 0;
            int buzzCnt = 0;
            int fizzbuzzCnt = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine("Fizz");
                    fizzCnt++;
                }
                else if ((i % 5 == 0) && (i % 3 != 0))
                {
                    Console.WriteLine("Buzz");
                    buzzCnt++;
                }
                else if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                    fizzbuzzCnt++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("Number of Fizz= " + fizzCnt);
            System.Console.WriteLine("Number of Buzz= " + buzzCnt);
            System.Console.WriteLine("Number of FizzBuzz= " + fizzbuzzCnt);
        }
    }
}

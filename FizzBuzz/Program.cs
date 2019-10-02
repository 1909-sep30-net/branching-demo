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
            if ((i % 3 == 0) && (i % 5 != 0))
            {
                Console.WriteLine("Fizz");
                fizzCount = fizzCount + 1;
            }
            if ((i % 3 != 0) && (i % 5 == 0))
            {
                Console.WriteLine("Buzz");
                buzzCount = buzzCount + 1;
            }
            if ((i % 3 == 0) && (i % 5 ==0))
            {
                Console.WriteLine("FizzBuzz");
                fizzBuzzCount = fizzBuzzCount + 1;
            }
            else
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Fizz Count =" + fizzCount);
            Console.WriteLine("Buzz Count =" + buzzCount);
            Console.WriteLine("FizzBuzz Count =" + fizzBuzzCount);
        }    

        }
    }
}

using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int divThreeAndFive = 0;
            int divThree = 0;
            int divFive = 0;

            for(int i = 1; i < 1001; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz:  " + i);
                    divThreeAndFive++;
                }

                else if(i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz:  " + i);
                    divThree++;
                }

                else if(i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzz:  " + i);
                    divFive++;
                }

                else
                {
                    Console.WriteLine("No Fizz, No Buzz: {0}", i);
                }

                
            }
            Console.WriteLine("Fizz - Divisible by three: " + divThree);
            Console.WriteLine("Buzz - Divisible by five: " + divFive);
            Console.WriteLine("Fizzbuzz - Divisible by three and Five: " + divThreeAndFive);
        }
    }
}

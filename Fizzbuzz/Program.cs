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
                int modThree = i % 3;
                int modFive = i % 5;

                if(modThree == 0 && modFive == 0)
                {
                    Console.WriteLine("Fizzbuzz:  " + i);
                    divThreeAndFive++;
                }

                if(modThree == 0 && modFive != 0)
                {
                    Console.WriteLine("Fizz:  " + i);
                    divThree++;
                }

                if(modThree != 0 && modFive == 0)
                {
                    Console.WriteLine("Buzz:  " + i);
                    divFive++;
                }

                
            }
            Console.WriteLine("Fizz - Divisible by three: " + divThree);
            Console.WriteLine("Buzz - Divisible by five: " + divFive);
            Console.WriteLine("Fizzbuzz - Divisible by three and Five: " + divThreeAndFive);
        }
    }
}

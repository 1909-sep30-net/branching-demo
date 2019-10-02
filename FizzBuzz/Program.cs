using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counters for the number of fizzes, buzzes, and fizzbuzzes that have been printed
            int numOfFizz = 0;
            int numOfBuzz = 0;
            int numOfFizzbuzz = 0;

            bool divByThree = false;
            bool divByFive = false;

            for(int i = 1; i <= 1000; i++)
            {
                divByThree = (i % 3 == 0);
                divByFive  = (i % 5 == 0);

                if(divByThree)
                {
                    if(divByFive)//3,5
                    {
                        Console.WriteLine("Fizzbuzz");
                        numOfFizzbuzz++;
                    }
                    else//3, !5
                    {
                        Console.WriteLine("Fizz");
                        numOfFizz++;
                    }
                }
                else if(divByFive)//!3, 5
                {
                    Console.WriteLine("Buzz");
                    numOfBuzz++;
                }
                else//!3,!5
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"The number of Fizzes was {numOfFizz}");
            Console.WriteLine($"The number of Buzzes was {numOfBuzz}");
            Console.WriteLine($"The number of Fizzbuzzes was {numOfFizzbuzz}");

        }
    }
}

using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            For each number from 1 to 1000 in order,
            * print "Fizz" for the ones divisible by 3 (& not 5)
            * print "Buzz" for the ones divisible by 5 (& not 3)
            * print "Fizzbuzz" for the ones divisible by both 3 and 5
            * print the number itself, for all the rest of the numbers
            Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz.

            
             */

             int count = 0;
             int countFizz = 0;
             int countBuzz = 0;
             int countFizzbuzz = 0;

             while(count <= 1000)
             {
                 count++;
                 if (count % 3 == 0 && count % 5 != 0)
                 {

                     System.Console.WriteLine("Fizz");
                     countFizz++;

                 } else if (count % 5 == 0 && count % 3 != 0)
                 {

                     System.Console.WriteLine("Buzz");
                     countBuzz++;

                 } else if (count % 3 == 0 && count % 5 == 0)
                 {

                     System.Console.WriteLine("Fizzbuzz");
                     countFizzbuzz++;

                 }
             }

            System.Console.WriteLine("----------");
             System.Console.WriteLine($"Fizzes : {countFizz}");
             System.Console.WriteLine($"Buzzes : {countBuzz}");
             System.Console.WriteLine($"Fizzbuzzes : {countFizzbuzz}");
        }
    }
}

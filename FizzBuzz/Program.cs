using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizzes = 0;
            int buzzes = 0;
            int fizzbuzzes = 0;
            
            for(int i=0;i<1001;i++)
            {
                if(i%3 == 0 && i%5 == 0)
                {
                    System.Console.WriteLine(i + " ------- FizzBuzz");
                    fizzbuzzes++;
                }
                else if (i%3==0)
                {
                    System.Console.WriteLine(i + " ------- Fizz");
                    fizzes++;
                }
                else if (i%5==0)
                {
                    System.Console.WriteLine(i + " ------- Buzz");
                    buzzes++;
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("Number of Fizzes: " + fizzes.ToString() + "\nNumber of Buzzes: " + buzzes.ToString() + "\nNumber of FizzBuzzes: " + fizzbuzzes.ToString());
        }
    }
}

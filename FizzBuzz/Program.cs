using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=1000;i++)
            {
                if(i%3 == 0 & i%5>1)
                {
                    Console.WriteLine(i + " Fizz");
                }
               else if(i%5==0 & i%3>1)
                {
                    Console.WriteLine(i + " Buzz");
                }
                else if(i%5==0 & i%3==0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                    
            }
        }
    }
}

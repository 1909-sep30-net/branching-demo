using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int sumFizz = 0, sumBuzz = 0, sumRest = 0;
            for(int i = 1; i <= 1000; i++) {
                if(i % 3 == 0 &&  i % 5 != 0) {
                    Console.WriteLine("Fizz | {0}", i);
                    sumFizz++;
                }
                else if (i % 5 == 0 && i % 3 != 0) {
                    Console.WriteLine("Buzz | {0}", i);
                    sumBuzz++;
                }
                else if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz | {0}", i);
                    sumRest++;
                }
            }
            Console.WriteLine("Number Of Times Fizz Occured: {0}", sumFizz);
            Console.WriteLine("Number Of Times Buzz Occured: {0}", sumBuzz);
            Console.WriteLine("Number Of Times Neither Occured Occured: {0}", sumRest);
        }
    }
}

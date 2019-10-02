using System;

namespace FizzBizz
{
    class Program
    {
        /*For each number from 1 to 1000 in order,
        * print "Fizz" for the ones divisible by 3 (& not 5)
        * print "Buzz" for the ones divisible by 5 (& not 3)
        * print "Fizzbuzz" for the ones divisible by both 3 and 5
        * print the number itself, for all the rest of the numbers
        Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz. 
       */
        static void Main(string[] args)
        {
            // Declared variables 
            int fizzBuzz =   0;
            int fizz     =   0; 
            int buzz     =   0;
            string ans = "";

            // Loop to 1000 find div 3 & 5
            for (int i = 1; i <= 1000; i++) {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    ans += "FizzBuzz";
                    fizzBuzz++;
                } else if(i % 3 == 0){
                    ans += "Fizz";
                    fizz++;
                }else if (i % 5 == 0 ){
                    ans += "Buzz";
                    buzz++;
                }else{
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine(ans + "\n");
            Console.WriteLine($" FuzzBuzz: {fizzBuzz}, Fizz: {fizz}, buzz: {buzz}");

        }
    }
}

using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int count =0, countF=0, countB=0, countFB=0;
            
            while(count <1000)
            {
                count++;

                if(count%3==0 ){
                    Console.WriteLine("Fizz");
                    countF++;
                }
                else if(count%5==0){
                    Console.WriteLine("Buzz");
                    countB++;
                }
                
                if( count %3==0 || count%5 ==0){
                    Console.WriteLine("FizzBuzz");
                    countFB++;
                }else
                    Console.WriteLine( "Rest: "+ count);


                
            }

            Console.WriteLine(" Fizz Count: "+ countF+" Buzz Count: "+ countB+" FizzBuzz Count:"+ countFB );

        }
    }
}

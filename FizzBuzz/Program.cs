using System;


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 1;


            while (i <= 100)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine(i + " Fizz___Buzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            Console.ReadLine();


        } // end of Main Method
    }  
}

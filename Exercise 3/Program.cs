using System;

namespace Exercise3
{
    class Program
    {
        static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7");
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even Number");
                }
                else
                {
                    Console.WriteLine("Odd Number");
                }
            }   
        }
        static void Main(string [] args)
        {
            Console.WriteLine("Please Enter a number");
            int number = int.Parse(Console.ReadLine());
            NestedCheck(number);
            Console.ReadLine();
        }
    }
}

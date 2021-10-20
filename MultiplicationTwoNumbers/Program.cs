using System;

namespace MultiplicationTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            while (condition)
            {
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if ( (num1 < 0) || (num1 > 10))
                {
                    Console.WriteLine($"The number {num1} is not valid! Please enter a number between [0; 10]!");
                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}

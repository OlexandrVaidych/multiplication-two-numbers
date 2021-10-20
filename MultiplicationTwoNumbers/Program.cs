using System;

namespace MultiplicationTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            int num1 = 0;
            int num2 = 0;
            int res;
            while (condition)
            {
                Console.Write("Enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                if ( (num1 < 0) || (num1 > 10))
                {
                    Console.WriteLine($"The number {num1} is not valid! Please enter a number between [0; 10]!");
                }
                else
                {
                    break;
                }
            }

            while (condition)
            {
                Console.Write("Enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if ((num2 < 0) || (num2 > 10))
                {
                    Console.WriteLine($"The number {num2} is not valid! Please enter a number between [0; 10]!");
                }
                else
                {
                    break;
                }
            }

            res = num1 * num2;
            
            Console.Write($"The result of multiplying {num1} by {num2}: {res}");
            
            Console.ReadKey();
        }
    }
}

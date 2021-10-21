using System;

namespace MultiplicationTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;
            bool cond = true;
            
            Console.WriteLine("Please enter a number between[0; 10]!");
            
            while (cond)
            {
                Console.Write("Enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if ( (num1 < 0) || (num1 > 10))
                {
                    Console.WriteLine($"The number {num1} is not valid! Please enter a number between [0; 10]!");
                }
                else if ((num2 < 0) || (num2 > 10))
                {
                    Console.WriteLine($"The number {num2} is not valid! Please enter a number between [0; 10]!");
                }
                else
                {
                    res = num1 * num2;
                    Console.Write($"The result of multiplication {num1} by {num2}: {res}");
                    break;
                }
            }
            
            Console.ReadKey();
        }
    }
}

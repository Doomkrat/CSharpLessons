using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            string userInput = Console.ReadLine();
            int number1 = int.Parse(userInput);
            Console.WriteLine("Enter second number: ");
            userInput = Console.ReadLine();
            int number2 = int.Parse(userInput);
            int sum = number1 + number2;
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The sum is: " + sum.ToString());
            Console.WriteLine("The sum is: " + (number1+number2));
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAndReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator calc = new SimpleCalculator();

            Console.WriteLine(calc.Square(4));
            Console.WriteLine(calc.AddTwoNumbers(10, 20));
            Console.WriteLine("Enter number: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine(calc.Square(number));

            Console.WriteLine(calc.FindMaxOfThree(10, 10, 10));

            Console.ReadLine();
        }
    }
}

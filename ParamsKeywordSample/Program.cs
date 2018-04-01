using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeywordSample
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSum(10, 20, 15, 11);
            Console.ReadLine();
        }

        static void PrintSum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}

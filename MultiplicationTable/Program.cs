using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t1\t2\t3\t4\t6\t7\t8\t9");

            for (int i = 0; i < 9; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("\t{0}", i * j);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
             
        }
    }
}

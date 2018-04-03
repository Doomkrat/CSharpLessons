using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 25, 15, 18, 26, 78, 1, 79, 3, 55, 7 };
            int[] array1 = { 25, 15, 18, 26, 78, 1, 79, 3, 55, 7 };
            Console.WriteLine("Not sorted array:");
            PrintElements(array);
            BubbleSort(array);
            Console.WriteLine("Bubble Sorted Array:");
            PrintElements(array);
            Console.WriteLine("Simple Sorted Array:");
            SimpleSort(array1);
            PrintElements(array1);
            Console.ReadLine();

            int[,] array2D = { { 5, 1, 110, 4, 12},
                               { 99, 44, 1100, 6, 13},
                                { 15, 11, 110, 14, 66},
                                 { 299, 444, 1100, 6, -5 } };
            Console.WriteLine("2D Array:");
            Print2DArray(array2D);
            Console.WriteLine("Sorted 2DArray:");
            SimpleSort2D(array2D);
            Print2DArray(array2D);
        }

        static void BubbleSort(int[] array)
        {
            var iter = 0;
            for (var i = array.Length - 1; i > 0; i--)
            {
                for (var j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                        iter++;
                    }
                }
            }
            Console.WriteLine("Total amount of iterations is {0}", iter);

        }
        static void PrintElements(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0} {1}", i, numbers[i]);

            }
        }

        private static void Print2DArray(int[,] numb)
        {

            var rowLength = numb.GetLength(0);
            var colLength = numb.GetLength(1);

            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", numb[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }

        static void SimpleSort(int[] array)
        {
            var iter = 0;
            for (var i = 0; i < array.Length - 1; i++)
            {
                var min = array[i];
                var index = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] >= min) continue;
                    min = array[j];
                    index = j;
                    iter++;
                }
                var tmp = array[i];
                array[i] = array[index];
                array[index] = tmp;
            }
            Console.WriteLine("Total amount of iterations is {0}", iter);
        }

        private static void SimpleSort2D(int[,] arr)
        {
            var iter = 0;
            var numberOfRows = arr.GetLength(0);
            var numberofColumns = arr.GetLength(1);

            for (var k = 0; k < numberOfRows; ++k)
            {
                for (var l = 0; l < numberofColumns; ++l)
                {
                    for (var i = 0; i < numberOfRows; ++i)
                    {
                        for (var j = 0; j < numberofColumns; ++j)
                        {
                            if ((i + 1) == numberOfRows && (j + 1) == numberofColumns) continue;

                            if ((j + 1 == numberofColumns) && (arr[i, j] > arr[i + 1, 0]))
                            {
                                var temp = arr[i, j];
                                arr[i, j] = arr[i + 1, 0];
                                arr[i + 1, 0] = temp;
                                iter++;
                            }
                            else
                            {
                                if (j + 1 == numberofColumns) continue;
                                if (arr[i, j] <= arr[i, j + 1]) continue;
                                var temp = arr[i, j];
                                arr[i, j] = arr[i, j + 1];
                                arr[i, j + 1] = temp;
                                iter++;
                            }
                        }
                    }
                }
                Console.WriteLine("Total amount of iterations is {0}", iter);
            }
        }
    }
}
    

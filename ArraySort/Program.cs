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
            Console.WriteLine("Not sorted array:");
            PrintElements(array);
            BubbleSort(array);
            Console.WriteLine("Bubble Sorted Array:");
            PrintElements(array);
            Console.WriteLine("Simple Sorted Array:");
            PrintElements(array);
            Console.ReadLine();

            int[,] array2D = { { 5, 1, 110 }, { 99, 4, 1100 } };
            Console.WriteLine("2D Array:");
            Print2dArray(array2D);
            Console.WriteLine("Sorted 2DArray:");
            SimpleSort2D(array2D);
            Print2dArray(array2D);
        }

        static void BubbleSort(int[] array)
        {

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }

        }
        static void PrintElements(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0} {1}", i, numbers[i]);

            }
        }

        static void Print2dArray(int[,] numb)
        {

            int rowLength = numb.GetLength(0);
            int colLength = numb.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", numb[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
        
        static void SimpleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = array[i];
                int index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        index = j;
                    }
                }
                int tmp = array[i];
                array[i] = array[index];
                array[index] = tmp;
            }
        }

        static void SimpleSort2D(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++) // Array Sorting
            {
                for (int j = arr.GetLength(1) - 1; j > 0; j--)
                {

                    for (int k = 0; k < j; k++)
                    {
                        if (arr[i, k] > arr[i, k + 1])
                        {
                            int temp = arr[i, k];
                            arr[i, k] = arr[i, k + 1];
                            arr[i, k + 1] = temp;
                        }
                    }
                }
            }

        }
    }
}

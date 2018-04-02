﻿using System;
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

            int[,] array2D = { { 5, 1, 110, 4, 15, 6, 8 }, 
                               { 99, 4, 1100, 6, 78, 9, 54 }, 
                                { 15, 11, 110, 14, 15, 6, 18 }, 
                                 { 299, 4, 1100, 6, 178, 9, 154 } };
            Console.WriteLine("2D Array:");
            Print2dArray(array2D);
            Console.WriteLine("Sorted 2DArray:");
            SimpleSort2D(array2D);
            Print2dArray(array2D);
        }

        static void BubbleSort(int[] array)
        {
            int iter = 0;
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
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
            int iter = 0;
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
                        iter++;
                    }
                }
                int tmp = array[i];
                array[i] = array[index];
                array[index] = tmp;
            }
            Console.WriteLine("Total amount of iterations is {0}", iter);
        }

        static void SimpleSort2D(int[,] arr)
        {
            int iter = 0;
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);
            for (int k = 0; k < n; ++k)
            {
                for (int l = 0; l < m; ++l)
                {
                    for (int i = 0; i < n; ++i)
                    {
                        for (int j = 0; j < m ; ++j)
                        {
                            if ((i + 1) == n && (j + 1) == m)
                            {
                                continue;
                            }
                            else
                            if ((j + 1 == m) && (arr[i, j] > arr[i + 1, 0]))
                            {
                                int temp = arr[i, j];
                                arr[i, j] = arr[i + 1, 0];
                                arr[i + 1, 0] = temp;
                                iter++;
                            }

                            else
                            if (arr[i, j] > arr[i, j + 1])
                            {
                                int temp = arr[i, j];
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
    

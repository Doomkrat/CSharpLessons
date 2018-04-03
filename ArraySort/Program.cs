using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {25, 15, 18, 26, 78, 1, 79, 3, 55, 7};
            int[] array1 = {25, 15, 18, 26, 78, 1, 79, 3, 55, 7};
            Console.WriteLine("Not sorted array:");
            PrintElements(array);
            BubbleSort(array);
            Console.WriteLine("Bubble Sorted Array:");
            PrintElements(array);
            Console.WriteLine("Simple Sorted Array:");
            SimpleSort(array1);
            PrintElements(array1);
            Console.ReadLine();

            
            Console.WriteLine("2D Array:");
            var someArray = Fill2DArray(10, 13);
            Print2DArray(someArray);
            Console.WriteLine("Sorted 2DArray:");
            SimpleSort2D(someArray);
            Print2DArray(someArray);
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
                    Console.Write($"{numb[i, j]} ");
                }

                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            Console.ReadLine();
        }

         public static int[,] Fill2DArray(int x , int y)
        {
            var mas = new int[x, y];
            var rand = new Random((int)Stopwatch.GetTimestamp());
            for (var i = 0; i < x; i++)
            for (var j = 0; j < y; j++)
                mas[i, j] = rand.Next(-150, 150);

            return mas;
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

            for (var k = 0; k < numberOfRows * numberofColumns; ++k)//Общий счетчик
            {
                for (var i = 0; i < numberOfRows; ++i)
                {
                    for (var j = 0; j < numberofColumns; ++j)
                    {
                        iter++;
                        if ((i + 1) == numberOfRows && (j + 1) == numberofColumns)
                        {
                            continue;//начинаем наш цикл заново если счетчик доходит до этих значений
                        }

                        if ((j + 1 == numberofColumns) && (arr[i, j] > arr[i + 1, 0]))//если элемент является последним в строке и больше чем первый элемент в следующей строке
                        {
                            var temp = arr[i, j];//то меняем их местами
                            arr[i, j] = arr[i + 1, 0];
                            arr[i + 1, 0] = temp;
                        }
                        else
                        {
                            if (j + 1 != numberofColumns)
                                if (arr[i, j] > arr[i, j + 1])
                                {
                                    var temp = arr[i, j];
                                    arr[i, j] = arr[i, j + 1];
                                    arr[i, j + 1] = temp;
                                }
                        }
                    }
                }
            }

            Console.WriteLine("Total amount of iterations is {0}", iter);
        }
    }
}

    

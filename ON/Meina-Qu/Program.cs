using System;
/**
 * Author: Meina Qu
 * Date: 01/12/01
 */
namespace hwk1
{
    class Program
    {
        /**
         * creates a two-dimensional array.
         */
        static int[,] createArray(int row, int column) {
            int[,] resultArray = new int [row, column];
            Random randomValue = new Random();
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < column; j++) {
                    // Fill the array with random numbers between 0 and 100
                    resultArray[i, j] = randomValue.Next(0, 100);
                }
            }
            return resultArray;
        }

        /**
         * Display the array values, numbers aligned
         */
        static void printArray(int [,] array) {
            int row = array.GetLength(0);
            int column = array.GetLength(1);
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < column; j++) {
                    Console.WriteLine("row{0} column{1}: {2}", i, j, array[i, j]);
                }
            }
        }

        /**
         * Search the array for the largest value
         */
        static void findMax(int [,] array) {
            int max = 0;
            int row = array.GetLength(0);
            int column = array.GetLength(1);
            int maxIndexRow = row;
            int maxIndexColumn = column;
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < column; j++) {
                    if (max < array[i, j]) {
                        max = array[i, j];
                        maxIndexRow = i;
                        maxIndexColumn = j;
                    }
                }
            }
            Console.WriteLine("The largest value is: {0}", max);
            Console.WriteLine(" The largest value's index row is: {0} and column{1}", maxIndexRow, maxIndexColumn);
        }

        static void Main(string[] args)
        {
            int row = 3;
            int column = 7;
            int [,] array = createArray(row, column);
            printArray(array);
            findMax(array);
        }
    }
}

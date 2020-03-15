using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01
{
    class Program
    {
        static void Main(string[] args)
        {
            int row;
            int col;
            Random rnd = new Random();


            Console.WriteLine("Please enter number of rows");
            row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter number of columns");
            col = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[row, col];

            for (int i=0; i<row; i++)
            {
                for (int j=0; j<col; j++)
                {
                    array[i,j] = rnd.Next(0, 100);
                }

            }

            int maxval = 0;
            int maxvalrow = 0;
            int maxvalcol = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (maxval <= array[i, j])
                    {
                        maxval = array[i, j];
                        maxvalrow = i;
                        maxvalcol = j;
                    }
                }

            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();

            }

            Console.WriteLine("The max value is " + maxval + "The max value index is (" + maxvalrow + "," + maxvalcol+")" );

            Console.Read();


        }
    }
}

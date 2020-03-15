using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here , number is greater than divisor

            int[] number = { 8, 17, 24, 5, 25 };
            int[] divisor = { 2, 0, 0, 5 };

            for(int j = 0; j < number.Length ; j++)

                //two different types of exception  , i.e. DivideByZeroException
                // and IndexOutOfRangeException raise here
                try
                {
                    Console.WriteLine("Number  :  " + number[j]);
                    Console.WriteLine("Divisor :  " + divisor[j]);
                    Console.WriteLine("Quotient:  " + number[j] / divisor[j]);

                }
                // Catch block 1
                // This Catch block is for handling DivideByZeroException
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Not possible to divide by zero ");
                }

               // Catch block 2
               // This Catch block is for handling IndexOutOfRangeException
               catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is Out of Range");

                }


        }
    }
}

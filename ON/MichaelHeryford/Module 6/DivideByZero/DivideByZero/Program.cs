using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 8, 17, 24, 5, 25 };
            int[] divisor = { 2, 0, 0, 5 };

            for (int i = 0; i < number.Length; i++)
            {
                try
                {
                    Console.WriteLine("Number: " + number[i]);
                    Console.WriteLine("Divisor: " + divisor[i]);
                    Console.WriteLine("Quotient: " + number[i]/divisor[i]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is out Range");
                }
            }
        }
    }
}

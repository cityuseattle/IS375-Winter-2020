using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPolymprphism
{
    class PrintData
    {
        void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("Printing double: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
        class Program
        {
            static void Main(string[] args)
            {
                PrintData printData = new PrintData();

                printData.print(5);
                printData.print(500.263);
                printData.print("Hello C#");
                Console.ReadKey();
            }
        }
    }
}

using System;

namespace StaticPolymprphism
{

    class Printdata
    {
        void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }

        public static void Main(string[] args)
        {
            Printdata p = new Printdata();

            p.print(5);

            p.print(500.263);

            p.print("Hello c++");
            Console.ReadKey();
        }
    }
}

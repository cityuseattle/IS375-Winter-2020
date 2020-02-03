using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void myfun(int p, int q)
        {
            Console.WriteLine(p - q);
        }
        static public void Main()
        {
            Action<int, int> val = myfun;
            val(20, 5);
        }
    }

}

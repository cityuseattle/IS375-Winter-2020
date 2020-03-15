using System;

namespace ActionDelegates
{
    class Program
    {
        public static void myfun(int p, int q) {
            Console.WriteLine(p - q);
        }

        public static void Main(string[] args)
        {
            Action<int, int> val = myfun;
            val(20, 5);
        }
    }
}

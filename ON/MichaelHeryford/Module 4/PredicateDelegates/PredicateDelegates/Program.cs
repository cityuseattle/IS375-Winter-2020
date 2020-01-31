using System;

namespace PredicateDelegates
{
    class Program
    {
        public static bool myfun(string myString)
        {
            if (myString.Length < 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Predicate<string> val = myfun;
            Console.WriteLine(val("GeeksforGeeks"));
        }
    }
}

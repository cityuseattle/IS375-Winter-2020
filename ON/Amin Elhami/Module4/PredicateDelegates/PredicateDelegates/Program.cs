using System;

namespace PredicateDelegates
{
    class Program
    {
        public static bool myfun(string mystring)
        {
            if (mystring.Length < 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void Main()
        {
            Predicate<string> val = myfun;
            Console.WriteLine(val("GeeksforGeeks"));
        }
    }
}

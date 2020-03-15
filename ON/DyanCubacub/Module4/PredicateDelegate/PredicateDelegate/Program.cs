using System;

namespace PredicateDelegate
{
    class Program
    {
        // Method
        public static bool myfun(string mystring)
        {
            if (mystring.Length < 7)
            {
                return true;
            }
            else { return false; 
            }
        }

        // Main method
        static public void Main()
        {
            // Using predicate delegate here, this delegate takes only one parameter
            Predicate<string> val = myfun;
            Console.WriteLine(val("GeeksforGeeks"));
        }
    }
}

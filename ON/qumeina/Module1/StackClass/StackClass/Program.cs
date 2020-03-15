using System;
using System.Collections;

namespace StackClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st) {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            st.Push('V');
            st.Push('H');
            Console.WriteLine("Push 'V' and 'H'");
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack");
            foreach (char c in st) {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing 3 values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st) {
                Console.Write(c + "");
            }
        }
    }
}

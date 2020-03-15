using System;
using System.Collections;

namespace StackClass
{
   class Program
   {

      static void CurrentStack(Stack st)
      {
         Console.WriteLine("Current stack:");
         foreach (char c in st)
         {
            Console.Write(c + " ");
         }
      }
      static void Main(string[] args)
      {
         Stack st = new Stack();
         st.Push('A');
         st.Push('M');
         st.Push('G');
         st.Push('W');

         CurrentStack(st);
         Console.WriteLine();

         st.Push('V');
         st.Push('H');
         Console.WriteLine("Push 'V' and 'H'");
         Console.WriteLine("The next popable value in stack: {0}", st.Peek());
 

  
         CurrentStack(st);
         Console.WriteLine();

         Console.WriteLine("Remove 3 values: ");
         st.Pop();
         st.Pop();
         st.Pop();
         CurrentStack(st);


      }
   }
}

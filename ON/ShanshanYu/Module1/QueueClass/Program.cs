using System;
using System.Collections;

namespace QueueClass
{
   class Program
   {
      static void Show(Queue q)
      { foreach (char c in q)
         { 
            Console.Write(c + " "); 
         }
         Console.WriteLine();
      }

      static void Main(string[] args)
      {
         Queue q = new Queue();

         q.Enqueue('A');
         q.Enqueue('M');
         q.Enqueue('G');
         q.Enqueue('W');

         Console.WriteLine("Current queue: ");
         Show(q);
         Console.WriteLine();
         q.Enqueue('V');
         q.Enqueue('H');
         Console.WriteLine("Current queue after adding V, H: ");
         Show(q);


         Console.WriteLine("Removing some values ");
         char ch = (char)q.Dequeue();
         Console.WriteLine("The removed value: {0}", ch);
         ch = (char)q.Dequeue();
         Console.WriteLine("The removed value: {0}", ch);
         Console.WriteLine("Current queue: ");
         Show(q);


      }
   }
}

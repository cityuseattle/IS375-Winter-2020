using System;
using System.Collections;

namespace ArrayListClass
{
   class Program
   {
      static void Main(string[] args)
      {
         ArrayList al = new ArrayList();
         al.Add(45);
         al.Add(78);
         al.Add(33);
         al.Add(56);
         al.Add(12);
         al.Add(23);
         al.Add(9);

         Console.WriteLine("Capacity:{0}",al.Capacity);
         Console.WriteLine("Count:{0}", al.Count);

         Console.WriteLine("Coutent: ");
         foreach (int i in al)
         {
            Console.Write(i + " ");
         }


         Console.WriteLine();
         Console.WriteLine("Sorted Coutent: ");
         al.Sort();
         foreach (int i in al)
         {
            Console.Write(i + " ");
         }
         Console.WriteLine();
      }
   }
}

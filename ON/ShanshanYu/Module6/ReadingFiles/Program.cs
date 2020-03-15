using System;
using System.IO;

namespace ReadingFiles
{
   class Program
   {
      static void Main(string[] args)
      {
         try {

            using (StreamReader sr = new StreamReader("D:/IS375-Winter-2020/ON/ShanshanYu/Module6/jamaica.txt"))
            {
               string line;
               while ((line = sr.ReadLine()) != null)
               { Console.WriteLine(line); }
            }
         
         }
         catch (Exception e)
         {
            Console.WriteLine("The file couldn't be read:");
            Console.WriteLine(e.Message);
         }
      }
   }
}

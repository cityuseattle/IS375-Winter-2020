using System;

namespace UserDefinedException
{
   class Program
   {
      static void Main(string[] args)
      {
         Temprature temp = new Temprature();
         try
         {
            temp.ShowTemp();
         }
         catch (TempIsZeroException e)
         {
            Console.WriteLine("TempIsZeroException: {0}", e.Message);
         }
      }
   }

   public class TempIsZeroException : Exception
   {
      public TempIsZeroException(string message) : base(message)
      {

      }
   }
   public class Temprature
   {
      int temprature = 0;
      public void ShowTemp()
      {
         if (temprature == 0)
         { throw (new TempIsZeroException("Zero Temprature found")); }
         else
         { Console.WriteLine("Temrature: {0}", temprature); }
      }
   }

   
}

using System;

namespace UserDefinedExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            try
            {
                temperature.showTemp();
            }
            catch (TempisZeroException e)
            {

                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
        }
    }

    public class TempisZeroException : Exception
    {
        public TempisZeroException(string message) : base(message)
        {

        }
    }
    public class Temperature
    {
        int temperature = 0;

        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempisZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
}

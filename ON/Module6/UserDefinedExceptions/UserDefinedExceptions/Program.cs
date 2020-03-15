using System;

namespace UserDefinedExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            // raises an user-defined exception i.e. TempIsZeroException
            try
            {
                temp.showTemp();
            }
            // catch block 1
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
        }
    }
}
public class TempIsZeroException : Exception
{
    public TempIsZeroException(string message) : base(message)
    {

    }
}

public class Temperature
{
    int temperature = 0; // set temperature to ZERO, so that it throws an exception
    
    public void showTemp()
    {
        // throw an exception if tmeperature is ZERO
        if (temperature == 0)
        {
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature: {0}", temperature);
        }
    }
}

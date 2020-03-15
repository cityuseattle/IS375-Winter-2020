using System;

namespace UserDefinedExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            // raises an user defined exception i.e. TempIsZeroException
            try
            {
                temp.showTemp();
            }
            // Catch block 1
            catch ( TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }

        }
    }
}
public class TempIsZeroException : Exception
{
    // User-defined exception classes are derived from  the Exception
    public TempIsZeroException(string message) : base(message)
    {

    }
}

public class Temperature
{
    int temperature = 0;        //set temperature to zero, so that it throws an exception
    
    public void showTemp()
    {
        //throw an exception if temperature is Zero
        if(temperature == 0 )
        {
            throw (new TempIsZeroException("Zero Temperature Found"));

        }
        else
        {
            Console.WriteLine("Temperature : {0}", temperature);
        }
    }
}

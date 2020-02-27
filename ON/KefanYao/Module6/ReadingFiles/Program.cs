using System;
using System.IO;

namespace ReadingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("./jamaica.txt"))
                {
                    string line;

                    while((line=sr.ReadLine())!=null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

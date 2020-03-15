using System;
using System.IO;

namespace ReadingFiles
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("/Users/qumeina/Projects/ReadingFiles/jamaica.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }
        }
    }
}

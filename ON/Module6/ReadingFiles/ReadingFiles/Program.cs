using System;
using System.IO;


namespace ReadingFiles
{
    class Program
    {
        static void Main()
        {

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(@"C:\Users\gabby\OneDrive\Desktop\C++ Intermediate\IS375-Winter-2020\ON\GabrielaWargin\Module6\ReadingFiles\jamaica.txt"))
                {
                    string line;

                    // Read and display lines from file until
                    // the end of the file is reached.

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }

            }
            catch (Exception e)
            {
                //Let the user know what went wrong.
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}

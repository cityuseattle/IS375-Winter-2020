using System;

namespace Encapsulation
{
    public class DemoEncap
    {
        private String studentName;
        private int studentAge;

        public String Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }


        public int Age
        {
            get
            {
                return studentAge;
            }
            set
            {
                studentAge = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DemoEncap obj = new DemoEncap();
            obj.Name = "Amin";
            obj.Age = 29;

            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}

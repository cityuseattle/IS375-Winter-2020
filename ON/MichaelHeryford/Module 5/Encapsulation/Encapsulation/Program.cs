using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            obj.Name = "Michael";
            obj.Age = 25;

            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}

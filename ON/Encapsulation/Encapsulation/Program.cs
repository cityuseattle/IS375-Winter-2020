using System;

namespace Encapsulation
{
   public class DemoEncap
    {
        //private variables declared
        //these can only be accessed by
        // public methods of class

        private String studentName;
        private int studentAge;

        //using accessors to get and
        //set the value of studentName

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

        //using accessors to get and
        // set the value of studentAge

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
            //creating object
            DemoEncap obj = new DemoEncap();

            //calls set accessor of the property Name,
            //and pass "Ankita" as value of the
            // standard field "value"
            obj.Name = "Ankita";

            //calls set accessor of the proeprty Age,
            // and pass "21" as value of the
            //standard field "value"
            obj.Age = 21;

            //displaying values of the variables
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}

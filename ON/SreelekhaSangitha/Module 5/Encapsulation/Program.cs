using System;

namespace Encapsulation
{
    public class DemoEncap
    {

        //private variables declared
        //these can be only accessed by
        // public methods of the class

        private String studentName;
        private int studentAge;

        //using accessors to get and 
        // set the value of studentName


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

        //using accessors to get and set
        // the value of studentAge

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
        class Program
        {
            static void Main(string[] args)
            {
                // creating object
                DemoEncap obj = new DemoEncap();

                //calls set accessor of the propertyName,
                // and pass "Ankita" as value of the
                // standard field 'value'

                obj.Name = "Ankita";

                //calls set accessor of the propertyAge,
                // and pass "21" as value of the
                // standard field 'value'

                obj.Age = 21;

                //Displaying values of variables
                Console.WriteLine("Name : " + obj.Name);
                Console.WriteLine("Age : " + obj.Age);
            }
        }
    }
}

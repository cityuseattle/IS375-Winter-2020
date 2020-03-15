using System;

namespace Abstraction
{
    abstract class Shape
    {
        // abstract method
        public abstract int area();
    }
    // square class inheriting the Shape class

    class Square : Shape
    {
        // private data member
        private int side;

        // method of square class
        public Square(int x = 0)
        {
            side = x;
        }

        // overriding of the abstract method of Shape
        // class using the overridekeyword

        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating reference of Shape class
            //which refer to Square class instance

            Shape sh = new Square(4);

            //calling the method
            double result = sh.area();

            Console.Write("{0}", result);
        }
    }
}

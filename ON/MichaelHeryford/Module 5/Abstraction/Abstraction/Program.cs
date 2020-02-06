using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Shape
    {
        //abstract method
        public abstract int area();
    }

    class Square : Shape
    {
        private int side;
        public Square(int x = 0)
        {
            side = x;
        }

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
            Shape shape = new Square(4);

            double result = shape.area();

            Console.Write("{0}", result);
        }
    }
}

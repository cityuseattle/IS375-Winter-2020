using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;
    }
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.setWidth(5);
            rectangle.setHeight(7);

            Console.WriteLine("Total area: {0}", rectangle.getArea());
        }
    }
}

using System;

namespace MulticastingDelegates
{
    class Rectangle
    {
        //declraing delegates
        public delegate void rectDelegate(double height, double width);
        //area method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));

        }
        //perimeter method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0}", 2 * (width + height));
        }
        //main method
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectDelegate rectDelegate = new rectDelegate(rectangle.area);

            rectDelegate += rectangle.perimeter;

            rectDelegate.Invoke(6.3, 4.2);
            Console.WriteLine();

            rectDelegate.Invoke(16.3, 10.3);
        }
    }
}

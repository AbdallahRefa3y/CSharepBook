using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    class TwoDShape
    {
        public double Width;
        public double Height;
        public void ShowDim()
        {
            Console.WriteLine("Width and height are " +
            Width + " and " + Height);
        }
    }
    // Triangle is derived from TwoDShape.
    class Triangle : TwoDShape
    {
        public string Style; // style of triangle
                             // Return area of triangle.
        public double Area()
        {
            return Width * Height / 2;
        }
        // Display a triangle's style.
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();
            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "isosceles";
            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "right";
            Console.WriteLine("Info for t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Info for t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area is " + t2.Area());


        }
    }
}

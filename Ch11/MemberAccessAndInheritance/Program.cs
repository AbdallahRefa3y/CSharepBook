using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberAccessAndInheritance
{

    class B
    {
        protected int i, j; // private to B, but accessible by D
        public void Set(int a, int b)
        {
            i = a;
            j = b;
        }
        public void Show()
        {
            Console.WriteLine(i + " " + j);
        }
    }

    class D : B
    {
        int k; // private
               // D can access B's i and j
        public void Setk()
        {
            k = i * j;
        }
        public void Showk()
        {
            Console.WriteLine(k);
        }
    }


    class TwoDShape
    {
        double pri_width; // now private
        double pri_height; // now private
                           // Properties for width and height.
        public double Width
        {
            get { return pri_width; }
            set { pri_width = value < 0 ? -value : value; }
        }
        public double Height
        {
            get { return pri_height; }
            set { pri_height = value < 0 ? -value : value; }
        }
        public void ShowDim()
        {
            Console.WriteLine("Width and height are " +
            Width + " and " + Height);
        }
    }
    // A derived class of TwoDShape for triangles.
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

            /////////////////////////////////////////

            D ob = new D();
            ob.Set(2, 3); // OK, known to D
            ob.Show(); // OK, known to D
            ob.Setk(); // OK, part of D
            ob.Showk(); // OK, part of D


        }   
    }
}       

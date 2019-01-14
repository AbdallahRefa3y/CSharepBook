using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnObjects
{

    class Factor
    {
        public int[] FindFactors(int num, out int numfactors)
        {
            int[] facts = new int[80]; // size of 80 is arbitrary
            int i, j;

            for (i = 2, j = 0; i < num / 2 + 1; i++)
                if ((num % i) == 0)
                {
                    facts[j] = i;
                    j++;
                }
            numfactors = j;
            return facts;
        }
    }


    class MyClass
    {
        int a, b;

        public MyClass Factory(int i, int j)
        {
            MyClass t = new MyClass();
            t.a = i;
            t.b = j;
            return t; 
        }

        public void Show()
        {
            Console.WriteLine("a and b: " + a + " " + b);
        }
    }


    class Rect
    {
        int width;
        int height;

        public Rect(int w, int h)
        {
            width = w;
            height = h;

        }

        public int area()
        {
            return width * height;

        }

        public void Show()
        {
            Console.WriteLine(width + " " + height);
        }

        public Rect Enlarge(int factor)
        {
            return new Rect(width * factor, height * factor);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Rect r1 = new Rect(4, 5);

            Console.Write("Dimensions of r1: ");
            r1.Show();

            Console.WriteLine("Area of r1: " + r1.area());


            Console.WriteLine();
            Console.WriteLine();

            Rect r2 = r1.Enlarge(2);

            Console.Write("Dimensions of r2: ");
            r2.Show();
            Console.WriteLine("Area of r2: " + r2.area());



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            MyClass ob = new MyClass();

            int i;
            int j;

            for (i = 0, j = 10; i < 10; i++, j--)
            {
                MyClass anotherOb = ob.Factory(i, j);
                anotherOb.Show();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //////////////////////////////////////


            Factor f = new Factor();
            int numfactors;
            int[] factors;
            factors = f.FindFactors(1000, out numfactors);
            Console.WriteLine("Factors for 1000 are: ");
            for (int s = 0; s < numfactors; s++)
                Console.Write(factors[s] + " ");


        }


        







    }
    
}

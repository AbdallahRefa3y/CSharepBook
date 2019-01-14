using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{

    class Overload2
    {
        public void MyMeth(int x)
        {
            Console.WriteLine("Inside MyMeth(int): " + x);
        }
        public void MyMeth(double x)
        {
            Console.WriteLine("Inside MyMeth(double): " + x);
        }

    }
        class Overload
    {
        public void OvlDemo()
        {
            Console.WriteLine("No parameters");
        }

        public void OvlDemo(int a)
        {
            Console.WriteLine("One parameter: " + a);
        }
      
        public int OvlDemo(int a, int b)
        {
            Console.WriteLine("Two parameters: " + a + " " + b);
            return a + b;
        }
        
        public double OvlDemo(double a, double b)
        {
            Console.WriteLine("Two double parameters: " +
            a + " " + b);
            return a + b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Overload ob = new Overload();
            int resI;
            double resD;
         
            ob.OvlDemo();
            Console.WriteLine();

            ob.OvlDemo(2);
            Console.WriteLine();

            resI = ob.OvlDemo(4, 6);
            Console.WriteLine("Result of ob.OvlDemo(4, 6): " + resI);
            Console.WriteLine();

            resD = ob.OvlDemo(1.1, 2.32);
            Console.WriteLine("Result of ob.OvlDemo(1.1, 2.32): " + resD);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            ////////////////////////////////////////////////////

            Overload2 ob_2 = new Overload2();
            int i = 10;
            double d = 10.1;
            byte b = 99;
            short s = 10;
            float f = 11.5F;

            ob_2.MyMeth(i); 
            ob_2.MyMeth(d); 
            ob_2.MyMeth(b); 
            ob_2.MyMeth(s);
            ob_2.MyMeth(f); 







        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStatic
{

    class Cons
    {
        public static int alpha;
        public int beta;

        static Cons()
        {
            alpha = 99;
            Console.WriteLine("Inside static constructor.");
        }

        public Cons()
        {
            beta = 100;
            Console.WriteLine("Inside instance constructor.");
        }
    }


    class MyClass
    {
        int a, b;
        // Create a class factory for MyClass.
        static public MyClass Factory(int i, int j)
        {
            MyClass t = new MyClass();
            t.a = i;
            t.b = j;
            return t; // return an object
        }
        public void Show()
        {
            Console.WriteLine("a and b: " + a + " " + b);
        }
    }

    class CountInst
    {
        static int Count = 0;

        public CountInst()
        {
            Count++;
        }

        ~CountInst()
        {
            Count--;
        }

        public static int GetCount()
        {
            return Count;
        }

    }


    class Program
    {
        class StaticDemo
        {
            public static int Val = 100;

            public static int ValDiv2()
            {
                return Val / 2;
            }
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Initial value of StaticDemo.Val is " + StaticDemo.Val);

            StaticDemo.Val = 8;
            Console.WriteLine("StaticDemo.Val is " + StaticDemo.Val);

            Console.WriteLine("StaticDemo.ValDiv2(): " + StaticDemo.ValDiv2());



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ///////////////////////////////////////

            CountInst ob;

            for(int i=0; i < 10; i++)
            {
                ob = new CountInst();
                Console.WriteLine("Current count: " + CountInst.GetCount());
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            /////////////////////////////////////////


            int s,k;

            for (s=0,k=10;s<10;s++,k--)
            {
                MyClass ob_2 = MyClass.Factory(s, k);

                ob_2.Show();
            }



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ///////////////////////////////////

            Cons ob_3 = new Cons();
            Console.WriteLine("Cons.alpha: " + Cons.alpha);
            Console.WriteLine("ob.beta: " + ob_3.beta);

        }
    }
}

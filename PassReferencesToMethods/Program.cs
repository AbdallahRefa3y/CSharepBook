using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassReferencesToMethods
{
    class MyClass
    {
        int alpha, beta;

        public MyClass(int i,int j)
        {
            alpha = i;
            beta = j;
        }

        public bool SameAs(MyClass ob)
        {
            if ((ob.alpha == alpha) & (ob.beta == beta))
                return true;
            else return false;
        }

        public void Copy(MyClass ob)
        {
            alpha =ob. alpha;
            beta =ob. beta;
        }

        public void Show()
        {
            Console.WriteLine("alpha: {0}, beta: {1}",alpha, beta);
        }

    }



    class Test
    {
        public void NoChanges(int i, int j)
        {
            i = i + j;
            j = -j;
        }

    }

    class Test_2
    {
        public int a, b;

        public Test_2 (int i, int j)
        {
            a = i;
            b = j;
        }

        public void Change(Test_2 ob)
        {
            ob.a = ob.a + ob.b;
            ob.b = -ob.b;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass(4, 5);
            MyClass ob2 = new MyClass(6, 7);

            Console.WriteLine("ob1 :");
            ob1.Show();

            Console.WriteLine();

            Console.WriteLine("ob2 :");
            ob2.Show();


            Console.WriteLine();

            if (ob1.SameAs(ob2))
                Console.WriteLine("ob1 and ob2 have the same values.");
            else
                Console.WriteLine("ob1 and ob2 have different values.");

            Console.WriteLine();


            ob1.Copy(ob2);
            Console.Write("ob1 after copy: ");
            ob1.Show();
            if (ob1.SameAs(ob2))
                Console.WriteLine("ob1 and ob2 have the same values.");
            else
                Console.WriteLine("ob1 and ob2 have different values.");

            Console.WriteLine();
            Console.WriteLine();

            int a = 15;
            int b = 20;

            Console.WriteLine("a and b befor call:   " + a + "   " + b);

            Test ob = new Test();

            ob.NoChanges(a,b);

            Console.WriteLine("a and b after call:   " + a + "   " + b);


            Console.WriteLine();
            Console.WriteLine();

            Test_2 ob_2 = new Test_2(15,10);

            Console.WriteLine("ob.a and ob.b before call: " +ob_2.a + " " + ob_2.b);
            ob_2.Change(ob_2);
            Console.WriteLine("ob.a and ob.b after call: " +ob_2.a + " " + ob_2.b);
        }









    }
    
}

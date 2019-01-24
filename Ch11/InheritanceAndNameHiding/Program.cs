using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndNameHiding
{
    //class A
    //{
    //    public int i = 0;
    //}
    //// Create a derived class.
    //class B : A
    //{
    //    new int i; // this i hides the i in A
    //    public B(int b)
    //    {
    //        i = b; // i in B
    //    }
    //    public void Show()
    //    {
    //        Console.WriteLine("i in derived class: " + i);
    //    }
    //}
    /// <summary>
    /// /////////////////////////////////
    /// </summary>
    /// 
    //class A
    //{
    //    public int i = 0;
    //}

    //class B : A
    //{
    //    new int i;

    //    public B(int a, int b)
    //    {
    //        base.i = a; // this uncovers the i in A
    //        i = b; // i in B
    //    }

    //    public void Show()
    //    {
    //        // This displays the i in A.
    //        Console.WriteLine("i in base class: " + base.i);
    //        // This displays the i in B.
    //        Console.WriteLine("i in derived class: " + i);
    //    }

    //}
    ////////////////////////////////////
    ///

    class A
    {
        public int i;

        public void Show()
        {
            Console.WriteLine("i in base class: " + i);
        }
    }

    class B : A
    {
        new int i; // this i hides the i in A
        public B(int a, int b)
        {
            base.i = a; // this uncovers the i in A
            i = b; // i in B
        }
        // This hides Show() in A. Notice the use of new.
        new public void Show()
        {
            base.Show(); // this calls Show() in A
                         // this displays the i in B
            Console.WriteLine("i in derived class: " + i);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //B ob = new B(2);
            //ob.Show();

            ////////////////////////////

            //B ob = new B(1, 2);
            //ob.Show();

            ////////////////////////////

            B ob = new B(1, 2);
            ob.Show();



        }
    }
}

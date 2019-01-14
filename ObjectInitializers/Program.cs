using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class MyClass
    {
        public int count;
        public string str;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass { count = 100, str = "testing" };

            Console.WriteLine(ob.count + "  " + ob.str);


            MyClass ob_2 = new MyClass { str = "test", count = 2000 };

            Console.WriteLine(ob_2.str + "  " + ob_2.count);


        }
    }
}

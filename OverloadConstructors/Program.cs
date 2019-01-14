using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadConstructors
{
    class XYCoord
    {
        public int x, y;
        public XYCoord() : this(0, 0)
        {
            Console.WriteLine("Inside XYCoord()");
        }
        public XYCoord(XYCoord obj) : this(obj.x, obj.y)
        {
            Console.WriteLine("Inside XYCoord(obj)");
        }
        public XYCoord(int i, int j)
        {
            Console.WriteLine("Inside XYCoord(int, int)");
            x = i;
            y = j;
        }
    }


    class Stack
    {
        char[] stck;
        int tos;

        public Stack(int size)
        {
            stck = new char[size];
            tos = 0;
        }

        public Stack(Stack ob)
        {
            stck = new char[ob.stck.Length];

            for (int i = 0; i < ob.tos; i++)
                stck[i] = ob.stck[i];
            
            tos = ob.tos;
        }

        public void Push(char ch)
        {
            if (tos == stck.Length)
            {
                Console.WriteLine(" -- Stack is full.");
                return;
            }
            stck[tos] = ch;
            tos++;
        }

        public char Pop()
        {
            if (tos == 0)
            {
                Console.WriteLine(" -- Stack is empty.");
                return (char)0;
            }
            tos--;
            return stck[tos];
        }


        public bool IsFull()
        {
            return tos == stck.Length;
        }

        public bool IsEmpty()
        {
            return tos == 0;
        }

        public int Capacity()
        {
            return stck.Length;
        }
       
        public int GetNum()
        {
            return tos;
        }
    }

    class MyClass
    {
        public int x;
        public MyClass()
        {
            Console.WriteLine("Inside MyClass().");
            x = 0;
        }
        public MyClass(int i)
        {
            Console.WriteLine("Inside MyClass(int).");
            x = i;
        }
        public MyClass(double d)
        {
            Console.WriteLine("Inside MyClass(double).");
            x = (int)d;
        }
        public MyClass(int i, int j)
        {
            Console.WriteLine("Inside MyClass(int, int).");
            x = i * j;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            MyClass t1 = new MyClass();
            MyClass t2 = new MyClass(88);
            MyClass t3 = new MyClass(17.23);
            MyClass t4 = new MyClass(2, 4);
            Console.WriteLine("t1.x: " + t1.x);
            Console.WriteLine("t2.x: " + t2.x);
            Console.WriteLine("t3.x: " + t3.x);
            Console.WriteLine("t4.x: " + t4.x);


            ///////////////////////////////////////

            Stack stk1 = new Stack(10);
            char ch;
            int i;
            // Put some characters into stk1.
            Console.WriteLine("Push A through J onto stk1.");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));
            // Create a copy of stck1.
            Stack stk2 = new Stack(stk1);
            // Display the contents of stk1.
            Console.Write("Contents of stk1: ");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }

            Console.WriteLine();
            Console.Write("Contents of stk2: ");
            while (!stk2.IsEmpty())
            {
                ch = stk2.Pop();
                Console.Write(ch);
            }
            Console.WriteLine("\n");



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //////////////////////////////////////


        }
    }
}

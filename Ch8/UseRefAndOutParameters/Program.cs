using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseRefAndOutParameters
{

    class RefTest
    {
        public void Sqr(ref int i)
        {
            i = i * i;
        }
    }

    class ValeSwap
    {
        public void Swap( ref int a,ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
    }



    class Decompose
    {
        public int GetParts(double n, out double frac)
        {
            int whole;
            whole = (int)n;
            frac = n - whole; 
            return whole; 
        }
    }


    class Num
    {
        public bool HasComFactor(int x, int y,out int least, out int greatest)
        {
            int i;
            int max = x < y ? x : y;
            bool first = true;
            least = 1;
            greatest = 1;
           
            for (i = 2; i <= max / 2 + 1; i++)
            {
                if (((y % i) == 0) & ((x % i) == 0))
                {
                    if (first)
                    {
                        least = i;
                        first = false;
                    }
                    greatest = i;
                }
            }
            if (least != 1) return true;
            else return false;
        }
    }





    class RefSwap
    {
        int a, b;
        public RefSwap(int i, int j)
        {
            a = i;
            b = j;
        }
        public void Show()
        {
            Console.WriteLine("a: {0}, b: {1}", a, b);
        }
       
        public void Swap(ref RefSwap ob1, ref RefSwap ob2)
        {
            RefSwap t;
            t = ob1;
            ob1 = ob2;
            ob2 = t;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            RefTest ob = new RefTest();

            int a = 10;

            Console.WriteLine("a before call: " + a);

            ob.Sqr(ref a);

            Console.WriteLine("a after call: " +a);

            ///////////////////////////////////////////////////

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            ValeSwap ob_2 = new ValeSwap();

            int x = 10;
            int y = 20;

            Console.WriteLine("x and y before call: " + x + " " + y);

            ob_2.Swap(ref x, ref y);
            Console.WriteLine("x and y after call: " + x + " " + y);

            //////////////////////////////////////////////////////////

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Decompose ob_3 = new Decompose();
            int i;
            double f;
            i = ob_3.GetParts(10.125, out f);
            Console.WriteLine("Integer portion is " + i);
            Console.WriteLine("Fractional part is " + f);

            //////////////////////////////////////////////////

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Num ob_4 = new Num();
            int lcf, gcf;
            if (ob_4.HasComFactor(231, 105, out lcf, out gcf))
            {
                Console.WriteLine("Lcf of 231 and 105 is " + lcf);
                Console.WriteLine("Gcf of 231 and 105 is " + gcf);
            }
            else
                Console.WriteLine("No common factor for 35 and 49.");
            if (ob_4.HasComFactor(35, 51, out lcf, out gcf))
            {
                Console.WriteLine("Lcf of 35 and 51 " + lcf);
                Console.WriteLine("Gcf of 35 and 51 is " + gcf);
            }
            else
                Console.WriteLine("No common factor for 35 and 51.");

            /////////////////////////////////////////////////////

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            RefSwap r = new RefSwap(1, 2);
            RefSwap w = new RefSwap(3, 4);
            Console.Write("x before call: ");
            r.Show();
            Console.Write("y before call: ");
            w.Show();
            Console.WriteLine();

            r.Swap(ref r, ref w);

            Console.Write("x after call: ");
            r.Show();
            Console.Write("y after call: ");
            w.Show();





        }
    }
}

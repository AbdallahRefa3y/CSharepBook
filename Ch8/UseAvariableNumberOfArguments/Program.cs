using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseAvariableNumberOfArguments
{
    class MyClass
    {
        public void ShowArgs(string msg, params int[] nums)
        {
            Console.Write(msg + ": ");
            foreach (int i in nums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }


    class Min
    {
        public int MinVal(params int[]nums)
        {

            int m;
            
            if (nums.Length == 0)
            {
                Console.WriteLine("Error No Arguments");
                return 0;
            }

            m = nums[0];
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] < m) m = nums[i];
            return m;

        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Min ob = new Min();

            int min;
            int a = 10;
            int b = 20;

            min = ob.MinVal(a, b);
            Console.WriteLine("Minimum is " + min);
         
            min = ob.MinVal(a, b, -1);
            Console.WriteLine("Minimum is " + min);
           
            min = ob.MinVal(18, 23, 3, 14, 25);
            Console.WriteLine("Minimum is " + min);
            
            int[] arg = { 45, 67, 34, 9, 112, 8 };
            min = ob.MinVal(arg);
            Console.WriteLine("Minimum is " + min);

            //////////////////////////////////////////////


            MyClass ob_2 = new MyClass();
            ob_2.ShowArgs("Here are some integers",1, 2, 3, 4, 5);
            ob_2.ShowArgs("Here are two more",17, 20);







        }
    }
}

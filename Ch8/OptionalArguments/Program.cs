using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArguments
{
    class OptionArgDemo
    {
        static void  OptArgMeth(int alpha,int beta=10,int gamma=20)
        {
            Console.WriteLine("Here is alpha, beta, and gamma: " +alpha + " " + beta + " " + gamma);
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {

            
            OptArgMeth(1, 2, 3);
            
            OptArgMeth(1, 2);
         
            OptArgMeth(1);
        }
    }
}

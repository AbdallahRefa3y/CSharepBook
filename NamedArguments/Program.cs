using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArguments
{

    class NamedArgsDemo
    {
        public bool IsFactor(int val ,int divisor)
        {
            if (val % divisor == 0) return true;
            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            NamedArgsDemo ob = new NamedArgsDemo();
            

            if (ob.IsFactor(10, 2))
                Console.WriteLine("2 is factor of 10.");

            if (ob.IsFactor(val: 10, divisor: 2))
                Console.WriteLine("2 is factor of 10.");

            if (ob.IsFactor(divisor: 2, val: 10))
                Console.WriteLine("2 is factor of 10.");

            if (ob.IsFactor(10, divisor: 2))
                Console.WriteLine("2 is factor of 10.");
        }


    }
    
}

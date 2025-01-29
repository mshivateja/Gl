using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Cust
    {
        int a;
        int b;
        public Cust(int A, int B)
        {
            
            a = A;
            b = B;

        }

        public void CValue()
        {

            Console.WriteLine($"A value {a}");
            Console.WriteLine($"B value {b}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate3
{
    class fibonacci
    {
        public static int Fibo(int a, int b, int n, int p)
        {
            if (n == p)
                return a;
            else
                return Fibo(b, a + b, n + 1, p);
        }
    }
}

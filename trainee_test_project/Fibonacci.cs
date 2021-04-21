using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainee_test_project
{
    public class Fibonacci
    {
        //calculate Fibonacci Sequence
        public int calculate_Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }
            return a;
        }
    }
}

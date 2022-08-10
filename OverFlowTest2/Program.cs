using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverFlowTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Add(5, 3);
            Console.WriteLine(sum1);
            double sum2 = Add(5.5, 3.5);
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }
    }
}

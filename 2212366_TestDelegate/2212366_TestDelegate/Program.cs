using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212366_TestDelegate
{
    internal class Program

    {
        public delegate int TinhToan(int a, int b);

        public static int Cong ( int a, int b)
        {
            return a + b;
        }

        public int Tru( int a, int b )
        {
            return a - b;
        }
        
        static void Main(string[] args)
        {
            TinhToan tt = new TinhToan(Cong);

            Console.WriteLine(tt(4,5));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akademia4
{
    class Program
    {
        static int silnia(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }
        static int fibb(int n)
        {
            if (n == 1 || n == 2)
                return 1;

            return fibb(n - 1) + fibb(n - 2);//rekurencja-odwołanie się do tej samej funkcji z pomniejszonym argumentem
        }
        static void Main(string[] args)
        {
            // Console.WriteLine(silnia(5));
            Console.WriteLine(fibb(3));
        }
    }
}
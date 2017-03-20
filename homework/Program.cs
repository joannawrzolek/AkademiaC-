using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        public static int Silnia(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int Fib(int n)
        {
            if (n < 2)
                return n;
            return Fib(n - 1) + Fib(n - 2);
        }


        static void Main(string[] args)
        {
            String line;
            int n;

            Console.WriteLine("Podaj dla jakiej liczby obliczyc silnie.\n");
            line = Console.ReadLine();
            n = int.Parse(line);

            //Console.WriteLine(n + "! = " + Silnia(n));
            Console.WriteLine("{0}! = {1}", n, Silnia(n));
            Console.WriteLine(Fib(n));

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akademia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            switch (randomizer.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("cos");
                    break;
                default:
                    Console.WriteLine("cos jeszcze");
                    break;
            }
        }
    }
}

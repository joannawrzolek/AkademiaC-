using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akademia
{
    class Program
    {
        static void Main(string[] args)
        {
            //wszystkie tablice sa dynamiczne
            string[] names = new string[3];
            names[0] = "Bolek";
            names[1] = "Marcin";
            names[2] = "Mical";  

            //logowanie 
            string name;
            bool logged = false;
            int attempt = 3;

            while(!logged && attempt > 0)
            {
                Console.WriteLine("Podaj login");
                name = Console.ReadLine();

                foreach(string item in names)
                {
                    if(name == item)
                    {
                        logged = true;
                        break;
                    }
                }
                attempt--;
            }
            if (logged)
            {
                Console.WriteLine("Dziala!!!");
            }
            else
            {
                Console.WriteLine("Nie dziala!!!");
            }
        }

    }
}

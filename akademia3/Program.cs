using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akademia3
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>();
            //string name;
            //bool end = false;
            //while (!end)
            ////while(true)
            //{
            //    name = Console.ReadLine();
            //    if (name == "end")
            //        break;
            //    names.Add(name.ToLower());
            //}
            //bool logged = false;
            //int attempt = 3;

            ////Console.WriteLine("Podaj login");
            //while (logged && attempt > 0) 
            //{
            //    name = Console.ReadLine();
            //    foreach(string item in names)
            //    {
            //        if (item == name)
            //        {
            //            logged = true;
            //            break;
            //        }
            //    }
            //    attempt--;
            //}
            //if (logged)
            //{
            //    Console.WriteLine("Dziala!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Nie dziala!!!");        
            //}  

            List<string> names = new List<string>();//deklaracja i inicjalizacja pustej listy
            string name;

            while (true)
            {
                name = Console.ReadLine();
                if (name == "end") break;
                names.Add(name.ToLower());//dodanie nowego elementu do listy
            }
            Console.Clear();

            Console.Write("Login: ");
            bool logged = false;
            int attempt = 3;
            while (!logged && attempt > 0)
            {
                name = Console.ReadLine();
                foreach (string item in names)
                {
                    if (item == name)
                    {
                        logged = true;
                        break;
                    }
                }
                attempt--;
            }


            if (logged)
                Console.WriteLine("dziala");
            else
                Console.WriteLine("nie dziala");
        }
    }
}

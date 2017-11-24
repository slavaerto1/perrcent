using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Сначала сумму потом проценты затем число месяцев");
            string a;
            a = Console.ReadLine();
            string d;
           d = Console.ReadLine();
            string c;
            c = Console.ReadLine();
            var t;
            Console.WriteLine(value:(t = (((a / 100) * d) * c) + a)); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");

            string entry;
            int n1, n2, res;

            Console.WriteLine("Ingrese un numero");
            entry = Console.ReadLine();
            n1 = Convert.ToInt32(entry);

            Console.WriteLine("Ingrese otro numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            res = n1 + n2;
            Console.WriteLine(res);
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;

            Console.WriteLine("Ingrese un numero");
            n1 = Convert.ToDouble(Console.ReadLine());

            if (n1 > 0)
            {
                Console.WriteLine("{0} es positivo", n1);
            }
            else
            {
                Console.WriteLine("{0} es negativo", n1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int propulsores, porcentaje;

            Console.WriteLine("ingrese cantidad de propulsores activos (max 2)");
            propulsores = Convert.ToInt32(Console.ReadLine());
            
            if(propulsores == 2) {
                Console.WriteLine("Propulsores disponibles: {0}", propulsores);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Ingrese porcentaje de combustible");
                porcentaje = Convert.ToInt32(Console.ReadLine());
                if(porcentaje >= 75) {
                    Console.WriteLine("Despegue autorizado");
                }
                else
                {
                    Console.WriteLine("Combustible insuficiente");
                }
            }
            if(propulsores == 1)
                {
                Console.WriteLine("Propulsores disponibles: {0}", propulsores);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Ingrese porcentaje de combustible");
                porcentaje = Convert.ToInt32(Console.ReadLine());
                if (porcentaje == 100)
                {
                    Console.WriteLine("Despegue autorizado");
                }
                else
                {
                    Console.WriteLine("Combustible insuficiente");
                }
                }
            else
            {
                Console.WriteLine("Propulsores incorrectos");
            }
        }
    }
}

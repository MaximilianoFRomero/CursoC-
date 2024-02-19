using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer programa que calcule el perimetro de cualquier poligono regular

            int cantidadLados;
            double tamanoLado, perimetro;

            Console.WriteLine("Ingrese cantidad de lados del poligono");
            cantidadLados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tamaño de uno de los lados");
            tamanoLado = Convert.ToDouble(Console.ReadLine());

            perimetro = tamanoLado * cantidadLados;

            Console.WriteLine("El perimetro del poligono es de: {0}", perimetro);
        }
    }
}

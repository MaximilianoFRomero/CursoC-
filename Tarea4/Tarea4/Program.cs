using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Ingrese una opcion:");
            Console.WriteLine("1 : Mes del año");
            Console.WriteLine("2 : Par o impar");
            Console.WriteLine("3 : Estacionamiento");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Mes del año.");
                    int mes;
                    Console.WriteLine("Ingrese un numero del 1 al 12");
                    mes = Convert.ToInt32(Console.ReadLine());
                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine("Enero");
                            break;
                        case 2:
                            Console.WriteLine("Febrero");
                            break;
                        case 3:
                            Console.WriteLine("Marzo");
                            break;
                        case 4:
                            Console.WriteLine("Abril");
                            break;
                        case 5:
                            Console.WriteLine("Mayo");
                            break;
                        case 6:
                            Console.WriteLine("Junio");
                            break;
                        case 7:
                            Console.WriteLine("Julio");
                            break;
                        case 8:
                            Console.WriteLine("Agosto");
                            break;
                        case 9:
                            Console.WriteLine("Septiembre");
                            break;
                        case 10:
                            Console.WriteLine("Octubre");
                            break;
                        case 11:
                            Console.WriteLine("Noviembre");
                            break;
                        case 12:
                            Console.WriteLine("Diciembre");
                            break;
                        default:
                            Console.WriteLine("Numero incorrecto");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Par o impar");
                    Console.WriteLine("Ingrese un numero");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num % 2 == 0)
                        Console.WriteLine("El numero {0} es par", num);
                    else
                        Console.WriteLine("El numero {0} es impar", num);
                    break;
                case 3:
                    Console.WriteLine("Estacionamiento");
                    int minutos, total;
                    Console.WriteLine("Ingrese cantidad de minutos");
                    minutos = Convert.ToInt32(Console.ReadLine());
                    if (minutos <= 60)
                    {
                        total = 5;
                        Console.WriteLine("Importe a abonar: ${0}.00", total);
                    }
                    if (minutos > 60 && minutos <= 120)
                    {
                        total = 15;
                        Console.WriteLine("Importe a abonar: ${0}.00", total);
                    }
                    if (minutos > 120)
                    {
                        total = 40;
                        Console.WriteLine("Importe a abonar: ${0}.00", total);
                    }
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        }
    }
}

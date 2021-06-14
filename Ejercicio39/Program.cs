using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double conversion;
                string opcion;
                Console.Clear();
                Console.WriteLine("Conversión de temperaturas Celsius");
                Console.Write("Ingrese la temperatura en grados celsius:");
                var celsius = Convert.ToDouble(Console.ReadLine());
                if (celsius > 15)
                {
                    Console.WriteLine("(F)ahrenheit");
                    Console.WriteLine("(R)eaumur");
                    Console.WriteLine("(K)elvin");
                    Console.WriteLine("R(A)nkine");
                    Console.Write("Ingrese la opción seleccionada:");
                    opcion = Console.ReadLine();

                    if (opcion.ToUpper()=="F" || opcion.ToUpper()=="R" || opcion.ToUpper()=="K" || opcion.ToUpper()=="A" )
                    {
                        switch (opcion.ToUpper())
                        {
                            case "F":
                                conversion = ConvertiraFahrenheit(celsius);
                                Console.WriteLine($"La conversión a Fah es {conversion}");
                                break;
                            case "R":
                                conversion = ConvertiraReaumur(celsius);
                                Console.WriteLine($"La conversión a Reaumur es {conversion}");
                                break;
                            case "K":
                                conversion = ConvertiraKelvin(celsius);
                                Console.WriteLine($"La conversión a Kelvin es {conversion}");
                                break;
                            default:
                                conversion = ConvertiraRankine(celsius);
                                Console.WriteLine($"La conversión a Rankine es {conversion}");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Opción no válida");
                    }

                }
                else
                {
                    Console.WriteLine("la temperatura debe ser superior a los 15 grados");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Algo se ingresó mal... Fin del programa");
            }
            Console.ReadLine();
        }

        private static double ConvertiraRankine(double celsius)
        {
            return 1.8 * celsius + 491.67;
        }

        private static double ConvertiraKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        private static double ConvertiraReaumur(double celsius)
        {
            return 0.8 * celsius;
        }

        private static double ConvertiraFahrenheit(double celsius)
        {
            return 1.8 * celsius + 32;
        }
    }
}

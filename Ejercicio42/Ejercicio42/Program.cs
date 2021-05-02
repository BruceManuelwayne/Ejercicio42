using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            bool ingresoCorrecto = false;
            Console.WriteLine("Ingrese una palabra para ser revertida:");
            //faltaria una validacion de solo letras:¿

            do
            {
                ingreso = Console.ReadLine();
                if (string.IsNullOrEmpty(ingreso))
                {
                    Console.WriteLine("ingrese una palabra valida: ");
                    continue;

                }
                else
                {
                    char[] arr = ingreso.ToCharArray();
                    Array.Reverse(arr);
                    string reverse = new string(arr); 
                    Console.WriteLine(reverse);
                    break;


                }
            } while (!ingresoCorrecto); 
            Console.ReadKey();
            
        }
    }
}

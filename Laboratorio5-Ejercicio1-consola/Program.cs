using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_Ejercicio1_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número 2 : ");
            int num2 = int.Parse(Console.ReadLine());
            int resul = 0;

            for ( int i = 0;  i < num2;  i++)   
            {
                resul = resul + num1;
            }
                Console.WriteLine("El producto es " + resul);
                Console.ReadKey();

        }
    }
}

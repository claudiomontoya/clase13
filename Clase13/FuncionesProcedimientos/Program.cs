using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesProcedimientos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                menu();
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    sumar();
                }
            } while (opcion != 0);
            menu();
           
            Console.ReadKey();
        }

        static void menu() {
            Console.WriteLine("**********************");
            Console.WriteLine("*1 sumar ");
            Console.WriteLine("*2 restar ");
            Console.WriteLine("*3 multiplicar");
            Console.WriteLine("*4 dividir");
            Console.WriteLine("**********************");
            Console.WriteLine("Ingrese una Opcion: ");
        }

        static void sumar()
        {
            Console.WriteLine("ingrese numero 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero 2");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma es :" + (n1 + n2));
        }
       

    }
}

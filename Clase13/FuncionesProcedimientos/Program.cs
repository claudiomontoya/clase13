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
                if (opcion < 5 && opcion > 0)
                {
                    operaciones(opcion);
                }
                else
                {
                Console.WriteLine("Opcion invalida!!"); break;
                }

            } while (opcion !=0);
            
           
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

        static void operaciones(int x)
        {
            Console.WriteLine("ingrese numero 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero 2");
            int n2 = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1: Console.WriteLine("La suma es :"+(n1+n2)); break;
                case 2: Console.WriteLine("La resta es :" + (n1 - n2)); break;
                case 3: Console.WriteLine("La multiplicacion es :" + (n1 * n2)); break;
                case 4: Console.WriteLine("La division es :" + (n1 / n2)); break;
                
            }


        }


    }
}

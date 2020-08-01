using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    class Program
    {
        static void Main(string[] args)
        {

            //Uso de Matrices registro de usuarios 

            string[,] usuarios = new string[3, 3];
            Console.WriteLine("Hello world");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese su Nombre:");
                usuarios[i, 0] = Console.ReadLine();

                Console.Write("Ingrese su Apellido:");
                usuarios[i, 1] = Console.ReadLine();

                Console.Write("Ingrese su Mail:");
                usuarios[i, 2] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Usuario:{0} Nombre:{1}  Apellido:{2}  Mail:{3}",i+1,usuarios[i,0], usuarios[i, 1], usuarios[i, 2]);
            }
            Console.ReadKey();
        }
    }
}

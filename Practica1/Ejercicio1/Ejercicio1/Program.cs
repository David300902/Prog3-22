using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Persona[] pe = new Persona[2];

           
            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("ingresa el nombre");
                p.nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad");
                p.edad = int.Parse(Console.ReadLine());
                pe[i] = new Persona();
                
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(pe[i]);
            }


            Console.ReadKey();


        }
    }

    class Persona
    {
        public string nombre;
        public int edad;
    }
}

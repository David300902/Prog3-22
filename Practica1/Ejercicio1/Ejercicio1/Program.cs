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
            string name;
            int age;

            Console.WriteLine("Cuantos datos desea ingresar?");
            int num = int.Parse(Console.ReadLine());
            Persona[,] registro = new Persona[num, num];

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("Ingrese el nombre");
                    name = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad");
                    age = int.Parse(Console.ReadLine());

                }
            }

        }
    }

    class Persona
    {
        string nombre;
        int edad;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {

        
        static void Main(string[] args)
        {

            int[] numeros = new int[10];
            Random r = new Random();

            Console.WriteLine("el array es: ");
            llenado(10);

            Console.WriteLine();
            Console.WriteLine("El resultado con el metodo es:");

            metodo(10);

            Console.ReadKey();


            
            void llenado(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    numeros[i] = r.Next(1, 10);
                    Console.Write(numeros[i] + " ");
                }
            }

            void metodo(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    for (int j = i+1; j < num; j++)
                    {
                        if (numeros[j] < numeros[i])
                        {
                            int aux = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = aux;
                        }
                    }
                }

                for (int i = 0; i < num; i++)
                {
                    Console.Write(numeros[i] + " ");
                }

            }
        }

        
    }

 
}

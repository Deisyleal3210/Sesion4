using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa vector 100");
            Console.WriteLine("Digitar el tamaño de vector: ");
            int tamanio, contador, contador3=0;
            int[] vector;
            tamanio=int.Parse(Console.ReadLine());
            vector = new int[tamanio];
            for (contador = 0; contador <= tamanio-1; contador++)
            {
                Console.WriteLine("Digite numero");
                vector[contador] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("el vector es: ");
            foreach(int contador2 in vector)
            {
                
                Console.WriteLine(contador2);
                if (contador2 > 100)
                {
                    contador3 = contador3 + 1;
                }
            }
            Console.WriteLine("Los numeros mayores que 100 son: "+contador3);
            Console.ReadKey();
        }
    }
}

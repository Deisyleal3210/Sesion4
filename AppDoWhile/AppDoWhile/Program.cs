using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0, valor;
            Console.WriteLine("Programa que suma valores");
           
            do
            {
                Console.WriteLine("Digite el valor: ");
                valor = int.Parse(Console.ReadLine());
                if (valor == 9999)
                {
                    break;
                }
                else
                {
                    suma = suma + valor;
                }
            }
            while (valor != 9999);

            Console.Write("El valor acumulado es: " + suma);
            
            if (suma == 0)
            {
                Console.Write(" El valor acumulado es igual a 0");
            }
            else if (suma > 0)
            {
                Console.Write(" El valor acumulado es mayor a 0");
            }
            else
            {
                Console.Write(" El valor acumulado es menor a 0");
            }
            Console.ReadKey();
        }
    }
}

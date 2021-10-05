using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista list = new Lista();
            int numeros = 0;
            int datos;
            Console.Write("Introduzca cuantos numeros va a introducir: ");
            numeros = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numeros; i++)
            {
                Console.Write("Introduzca los numeros: ");
                datos = Convert.ToInt32(Console.ReadLine());
                list.Insertar(datos);
            }
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Lista sin Ordenar ");
            list.Imprimir();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Lista Ordenada Descendente ");
            list.Descente();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Lista Ordenada Ascendente");
            list.Ascendente();
            Console.ReadLine();
        }
    }
}

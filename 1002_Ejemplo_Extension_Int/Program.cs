using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002_Ejemplo_Extension_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de métodos de clase (int) extendida\n");
            Console.WriteLine("Potencia:"+ 6.ElevadoA(2));
            Console.WriteLine("Potencia:" + 5.ElevadoA(3));
            Console.WriteLine("Doble: " + 65.Doble());
            Console.Read();
        }
    }

    //Obligatoriamente estáticos tanto la clase como los métodos.
    public static class IntegerExtensionMethods
    {
        public static double ElevadoA(this int valor, int exponente)
        {
            return Math.Pow(valor, exponente);
        }

        /// <summary>
        /// Calcula el doble de un número.
        /// </summary>
        /// <param name="valor">El contexto actual y el tipo</param>
        /// <returns>Resultado</returns>
        /// 
        public static double Doble(this int valor)
        {
            return valor * 2;
        }
    }
}

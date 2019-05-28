using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoGenerico_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            MiColeccion<int> coleccion = new MiColeccion<int>();
            coleccion.Agregar(54);

            MiColeccion<string> coleccion2 = new MiColeccion<string>();
            coleccion2.Agregar("Valor");

            int[][] enteros = new int[2][];

            enteros[2] = new int[10];
        }
    }

    class MiColeccion<T>
    {
        List<T> MiLista { get; set; }

        public MiColeccion()
        {
            MiLista = new List<T>();
        }

        public void Agregar(T item)
        {
            MiLista.Add(item);
        }
    }
}

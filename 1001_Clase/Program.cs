using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector(new List<int> { 3,5,3});
            Vector v2 = new Vector(new List<int> { 1, 1, 2 });
            Vector vectorSuma = v.Suma(v2);
            Console.WriteLine("resultado: " + vectorSuma[0] + " " + vectorSuma[1] + " " + vectorSuma[2]);
            Vector vectorSuma2 = v + v2;
            Console.WriteLine("resultado: " + vectorSuma2[0] + " " + vectorSuma2[1] + " " + vectorSuma2[2]);
            Console.Read();
        
        }
    }

    class Vector
    {
        private List<int> _componentes;

        public List<int> Componentes
        {
            get
            {
                return _componentes;
            }
        }

        //Propiedades
        public int Dimension
        {
            get
            {
                return _componentes.Count;
            }
        }

        //Indexador
        public int this[int i]
        {
            get
            {
                return _componentes[i];
            }
            set
            {
                _componentes[i] = value;
            }
        }

        public Vector(List<int> componentes)
        {
            _componentes = componentes;
        }

        public Vector Suma(Vector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("Las dimensiones no son iguales.");
            }
            List<int> resultado = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                resultado.Add(this[i] + v2[i]);
            }
            return new Vector(resultado);
        }

        //Operadores
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return vector1.Suma(vector2);
        }

        public static int operator *(Vector vector1, Vector vector2)
        {
            return vector1.Suma(vector2)[0];
        }
    }
}

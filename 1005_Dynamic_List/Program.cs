using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1005_Dynamic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalito1 = new { animal = "perro", nombre="perro1", vidas=1 };
            var animalito2 = new { animal = "gato", nombre = "gato1", vidas=7 };

            List<dynamic> animalitos = new List<dynamic> ();
            animalitos.Add(animalito1);
            animalitos.Add(animalito2);

            foreach (dynamic animalito in animalitos)
            {
                Console.WriteLine("El {0} de nombre {1} tiene {2} vidas.", animalito.animal, animalito.nombre, animalito.vidas);
            }
            Console.Read();
        }
    }
}

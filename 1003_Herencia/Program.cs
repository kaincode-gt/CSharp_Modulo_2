using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new Vaca("vaca1"));
            animales.Add(new Oveja("oveja1"));

            animales[0].HacerRuido();
            animales[1].HacerRuido();
            Console.Read();
        }


        class Animal
        {
            public string Nombre { get; set; }

            public virtual void HacerRuido()
            {
                Console.WriteLine("{0} hace ruido.", Nombre);
            }
        }

        class Vaca : Animal
        {
            
            public Vaca (string nombre)
            {
                Nombre = nombre;
            }

            public override void HacerRuido()
            {
                Console.WriteLine("{0} dice muu", Nombre);
            }

            public void Limpiar()
            {
                Console.WriteLine("La vaca {0} ha sido limpiada", Nombre);
            }
        }

        class Oveja : Animal
        {

            public Oveja(string nombre)
            {
                Nombre = nombre;
            }

            public override void HacerRuido()
            {
                Console.WriteLine("{0} dice beeh", Nombre);
            }

            public void Trasquilar()
            {
                Console.WriteLine("La oveja {0} ha sido trasquilada", Nombre);
            }
        }
    }
}

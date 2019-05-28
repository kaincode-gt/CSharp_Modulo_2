using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _1006_Tipos_genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona() { Nombre = "Pedro" };
            var xml_personal = Serializar(persona1);

            var persona2 = new Persona() { Nombre = "Julio" };
            var xml_persona2 = Serializar<Persona>(persona2);

            var empresa1 = new Empresa() { Direccion = "Calle sin número" };
            var xml_empresa1 = Serializar(empresa1);
        }

        private static string Serializar<T>(T valor)
        {
            var serializador = new XmlSerializer(typeof(T));

            using (var escritorString = new StringWriter())
            {
                using (var escritor = XmlWriter.Create(escritorString))
                {
                    serializador.Serialize(escritor, valor);
                    return escritorString.ToString();
                }
            }
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
    }

    public class Empresa
    {
        public string Direccion { get; set; }
    }
}

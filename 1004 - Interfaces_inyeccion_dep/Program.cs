using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1004___Interfaces_inyeccion_dep
{
    class Program
    {
        static void Main(string[] args)
        {
            var enviadorMensajeDependencia = FactoriaEnviadorMensaje.Factoria("SMS");
            var enviadorMensaje = new EnviadorMensaje(enviadorMensajeDependencia);

            //Sin usar Factoría
            //var enviadorSMS = new EnviarCorreo();
            //var enviadorMensaje = new EnviadorMensaje(enviadorSMS);
            enviadorMensaje.EnviarMensaje("BOOM!");
            Console.Read();
        }
    }

    public static class FactoriaEnviadorMensaje
    {
        public static IEnviadorMensaje Factoria(string parametro)
        {
            if (parametro == "SMS")
            {
                return new EnviarMiniMensaje();
            }
            else if (parametro == "correo")
            {
                return new EnviarCorreo();
            }
            throw new ApplicationException();
        }
    }

    public class EnviadorMensaje
    {
        public EnviadorMensaje(IEnviadorMensaje enviadorMensaje)
        {
            _enviadorMensaje = enviadorMensaje;
        }

        private IEnviadorMensaje _enviadorMensaje;

        public void EnviarMensaje(string mensaje)
        {
            _enviadorMensaje.EnviarMensaje(mensaje);
        }
    }

    public interface IEnviadorMensaje
    {
        void EnviarMensaje(string mensaje);
    }

    public class EnviarMiniMensaje : IEnviadorMensaje
    {
        void IEnviadorMensaje.EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando minimensaje: " + mensaje);
        }
    }

    public class EnviarCorreo : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Envianado correo: " + mensaje);
        }
    }
}

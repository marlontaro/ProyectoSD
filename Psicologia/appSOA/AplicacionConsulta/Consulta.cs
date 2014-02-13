using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace AplicacionConsulta
{
    public class Consulta
    {
        public static void Main(string[] args)
        {
            string rutacola = @".\private$\hconsulta";
            if (!MessageQueue.Exists(rutacola))
                MessageQueue.Create(rutacola);
            MessageQueue cola = new MessageQueue(rutacola);
            Message mensaje = new Message();
            mensaje.Label = "Nueva Consulta";
            mensaje.Body = new Entrevista() { Codins = 1, Dni = "00000001", Estado = 2 };
            cola.Send(mensaje);
            Console.ReadLine();
        }
    }
    public class Entrevista
    {
        public int Codins { get; set; }
        public string Dni { get; set; }
        public int Estado { get; set; }
    }

}

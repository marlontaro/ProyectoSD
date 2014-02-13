using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;

namespace ConsultaRespuesta
{
    public class Respuesta
    {
        public static void Main(string[] args)
        {
            string rutacola = @".\private$\hconsulta";
            if (!MessageQueue.Exists(rutacola))
                MessageQueue.Create(rutacola);
            MessageQueue cola = new MessageQueue(rutacola);
            cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Entrevista) });
            Message mensaje = cola.Receive();
            Entrevista resultado = (Entrevista)mensaje.Body;
            Console.WriteLine("Asunto: " + mensaje.Label);
            Console.WriteLine("Codigo de Entrevista: " + resultado.Codins + ", DNI: " + resultado.Dni +
                " Estado Entrevista: " + resultado.Estado);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;


namespace ConsoleApplication1
{
    public class Consulta
    {
        public static void Main(string[] args)
        {
            string rutaCola = @".\private$hconsulta";
            if (!MessageQueue.Exists(rutaCola))
                MessageQueue.Create(rutaCola);
            MessageQueue cola = new MessageQueue(rutaCola);
            Message mensaje = new Message();
            mensaje.Label = "Resultado Entrevista Psicologica";
            mensaje.Body = new Estado() { Codins = 3, DNI = "00000001", Tipo = 3 };
            cola.Send(mensaje);
            Console.ReadLine();

        }
    }
    public class Estado
    {
        public int Codins { get; set; }
        public string DNI { get; set; }
        public int Tipo { get; set; }
    }

}

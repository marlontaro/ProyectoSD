using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class Resultado
    {
        private int valor = 0;
        private String descripcion = string.Empty;

        [DataMember]
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}

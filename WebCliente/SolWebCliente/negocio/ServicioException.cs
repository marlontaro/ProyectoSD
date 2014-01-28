using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.negocio
{
    public class ServicioException : Exception
    {
        public ServicioException()
            : base()
        {

        }

        public ServicioException(string mensaje)
            : base(mensaje)
        {

        }

        public ServicioException(string mensaje, Exception excepcionAnidada)
            : base(mensaje, excepcionAnidada)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EL;
using DL;

namespace BL
{
    public class BL_Inscripcion
    {

        // Expedientes
        public List<EL_Inscripcion> Get_ListarDatos(Int32 P_CodigoInscripcion, string P_DNI, string P_Nombre, string P_ApellidoPaterno, string P_ApellidoMaterno)
        {
            DL_Inscripcion p = new DL_Inscripcion();
            return p.Get_ListarDatos(P_CodigoInscripcion, P_DNI, P_Nombre, P_ApellidoPaterno, P_ApellidoMaterno);
        }

    }
}

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
        public List<EL_Inscripcion> Get_ListarDatos(string P_DNI)
        {
            DL_Inscripcion p = new DL_Inscripcion();
            return p.Get_ListarDatos(P_DNI);
        }

    }
}

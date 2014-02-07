using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using EL;
using BL;

namespace appSOA
{
    /// <summary>
    /// Summary description for wsInscripcion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsInscripcion : System.Web.Services.WebService
    {

        /// <summary>
        /// Metodo que devuelve los expedientes
        /// </summary>
        /// <returns></returns>
        /// Nota: Cuando el WebService esta dentro del CodeBehid se debe poner static: public static ...
        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public List<EL_Inscripcion> Get_ListarDatos(Int32 P_CodigoInscripcion, string P_DNI, string P_Nombre, string P_ApellidoPaterno, string P_ApellidoMaterno)
        {
            try
            {

                List<EL_Inscripcion> Lista = new List<EL_Inscripcion>();

                BL_Inscripcion p = new BL_Inscripcion();
                Lista = p.Get_ListarDatos(P_CodigoInscripcion, P_DNI, P_Nombre, P_ApellidoPaterno, P_ApellidoMaterno);


                return Lista;

            }

            catch
            {
                return null;
            }
        }
    
    }
}

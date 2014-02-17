using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dominio;

namespace it.negocio
{
    public interface IAdministracion
    {
        IList<Ubigeo> ListarDepartamento();
        IList<Ubigeo> ListarProvincia(string cDepartamento);
        IList<Ubigeo> ListarDistrito(string cProvincia);

        IList<Seccion> ListarSeccion(int nSeccion);

        Inscripcion InscripcionInd(int nCodigo);
        void InscripcionInsertar(Inscripcion oInscripcion, IList<InscripcionDetalle> oListaDetalle);
        void InscripcionEditar(Inscripcion oInscripcion, IList<InscripcionDetalle> oListaDetalle);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dominio;

namespace it.negocio
{
    public class Administracion : IAdministracion
    {
        private IList<Ubigeo> oListaUbigeo;

        public IList<Ubigeo> ListarDepartamento()
        {
            oListaUbigeo = new List<Ubigeo>();

            using(DbContext dbContext= new DbContext()){

                oListaUbigeo = (from ent in dbContext.Ubigeos
                                where ent.CodigoUbigeo.Trim().Substring(2,4).Equals("0000")
                                select ent).ToList();

            }

            return oListaUbigeo;
        }

        public IList<Ubigeo> ListarProvincia(string cDepartamento)
        {
            oListaUbigeo = new List<Ubigeo>();

            using (DbContext dbContext = new DbContext())
            {

                oListaUbigeo = (from ent in dbContext.Ubigeos
                                where ent.CodigoUbigeo.Substring(0,2).Equals(cDepartamento) && 
                                      ent.CodigoUbigeo.Trim().Substring(4, 2).Equals("00") &&
                                      !ent.CodigoUbigeo.Trim().Substring(2,4).Equals("0000")
                                select ent).ToList();

            }

            return oListaUbigeo;
        }

        public IList<Ubigeo> ListarDistrito(string cProvincia)
        {
            oListaUbigeo = new List<Ubigeo>();

            using (DbContext dbContext = new DbContext())
            {

                oListaUbigeo = (from ent in dbContext.Ubigeos
                                where ent.CodigoUbigeo.Substring(0, 4).Equals(cProvincia) &&
                                      !ent.CodigoUbigeo.Trim().Substring(4, 2).Equals("00")                                     
                                select ent).ToList();

            }

            return oListaUbigeo;
        }

        public IList<Seccion> ListarSeccion(int nSeccion) {
            IList<Seccion> oListaSeccion = new List<Seccion>();

            using (DbContext dbContext = new DbContext()) {
                oListaSeccion = (from ent in dbContext.Seccions
                                 where ent.Educacion == nSeccion
                                 select ent).ToList();
            }

            return oListaSeccion;
        }


        public void InsertarInscripcion(Inscripcion oInscripcion)
        {
            
        }
    }
}

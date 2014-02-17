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


        public Inscripcion InscripcionInd(int nCodigo) {
            Inscripcion oInscripcion = new Inscripcion();

            using (DbContext dbContext = new DbContext()) {
                oInscripcion = (from ent in dbContext.Inscripcions
                                where ent.CodigoInscripcion == nCodigo
                                select ent).FirstOrDefault();
            }
            return oInscripcion;
        }

        public void InscripcionInsertar(Inscripcion oInscripcion, IList<InscripcionDetalle> oListaDetalle)
        {
            using (DbContext dbContext = new DbContext())
            {
                dbContext.Add(oInscripcion);
                dbContext.SaveChanges();

                foreach (InscripcionDetalle oDetalle in oListaDetalle)
                {
                    oDetalle.CodigoInscripcion = oInscripcion.CodigoInscripcion;
                    oDetalle.Seccion = null;
                    dbContext.Add(oDetalle);
                    dbContext.SaveChanges();

                    // insertar evaluacion

                    if (oDetalle.EsAcademico == true)
                    {
                        Usuario oUAcademica = new Usuario();
                        oUAcademica = (from ent in dbContext.Usuarios
                                       from per in ent.Perfils
                                       where per.Nombre.Equals("Aprobador Academico", StringComparison.CurrentCultureIgnoreCase)
                                       select ent).Distinct().FirstOrDefault();

                        // fecha 
                        DateTime dFechaConsulta = new DateTime();

                        Evaluacion oTAcademica = new Evaluacion();
                        oTAcademica = (from ent in dbContext.Evaluacions
                                       where ent.Tipo == 1
                                       select ent).LastOrDefault();

                        if (oTAcademica != null)
                        {
                            if (oTAcademica.CodigoEvaluacion != 0)
                            {
                                dFechaConsulta = oTAcademica.Fecha.Value.AddMinutes(30);

                            }
                            else {
                                dFechaConsulta = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,
                                                    9,0,0);
                            }
                        }
                        else {
                            dFechaConsulta = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                                                9, 0, 0);
                        }

                        Evaluacion oAcademica = new Evaluacion();
                        oAcademica.CodigoInscripcionDetalle = oDetalle.CodigoInscripcionDetalle;
                        oAcademica.Tipo = 1; //academico
                        oAcademica.CodigoUsuario = oUAcademica.CodigoUsuario;
                        oAcademica.Fecha = dFechaConsulta;
                        oAcademica.Evaluador = String.Format("{0} {1} {2}", oUAcademica.Persona.Nombre, oUAcademica.Persona.ApellidoPaterno, oUAcademica.Persona.ApellidoMaterno);
                        dbContext.Add(oAcademica);
                        dbContext.SaveChanges();
                    }

                    if (oDetalle.EsDirecccion == true)
                    {
                        Usuario oUDireccion = new Usuario();
                        oUDireccion = (from ent in dbContext.Usuarios
                                       from per in ent.Perfils
                                       where per.Nombre.Equals("Aprobador Director", StringComparison.CurrentCultureIgnoreCase)
                                       select ent).Distinct().FirstOrDefault();

                        // fecha 
                        DateTime dFechaConsulta = new DateTime();

                        Evaluacion oTAcademica = new Evaluacion();
                        oTAcademica = (from ent in dbContext.Evaluacions
                                       where ent.Tipo == 1
                                       select ent).LastOrDefault();

                        if (oTAcademica != null)
                        {
                            if (oTAcademica.CodigoEvaluacion != 0)
                            {
                                dFechaConsulta = oTAcademica.Fecha.Value.AddMinutes(30);

                            }
                            else
                            {
                                dFechaConsulta = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                                                    9, 0, 0);
                            }
                        }
                        else
                        {
                            dFechaConsulta = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                                                9, 0, 0);
                        }

                        Evaluacion oDireccion = new Evaluacion();
                        oDireccion.CodigoInscripcionDetalle = oDetalle.CodigoInscripcionDetalle;
                        oDireccion.Tipo = 3; //direccion
                        oDireccion.CodigoUsuario = oUDireccion.CodigoUsuario;


                        dbContext.Add(oDireccion);
                        dbContext.SaveChanges();

                    }

                }
            }
        }

        public void InscripcionEditar(Inscripcion oInscripcion, IList<InscripcionDetalle> oListaDetalle) {
            Inscripcion oTInscripcion = new Inscripcion();

            using (DbContext dbContext = new DbContext())
            { 
                oTInscripcion = (from ent in dbContext.Inscripcions
                                     where ent.CodigoInscripcion == oInscripcion.CodigoInscripcion
                                select ent).FirstOrDefault();
                
                if (oTInscripcion != null) {
                    oTInscripcion.DNI = oInscripcion.DNI;
                    oTInscripcion.Nombre = oInscripcion.Nombre;
                    oTInscripcion.ApellidoPaterno = oInscripcion.ApellidoPaterno;
                    oTInscripcion.ApellidoMaterno = oInscripcion.ApellidoMaterno;
                    oTInscripcion.Direccion = oInscripcion.Direccion ;
                    oTInscripcion.CodigoUbigeo = oInscripcion.CodigoUbigeo ;
                    oTInscripcion.Tipo = oInscripcion.Tipo ;
                    oTInscripcion.Telefono = oInscripcion.Telefono;

                    dbContext.SaveChanges();
                }

            }
        }


    }
}

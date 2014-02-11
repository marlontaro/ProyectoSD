using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EL
{
    public class EL_Inscripcion
    {

        private int m_CodigoInscripcion;
        public int CodigoInscripcion
        {
            get { return m_CodigoInscripcion; }
            set { m_CodigoInscripcion = value; }
        }
        private string m_DNI;
        public string DNI
        {
            get { return m_DNI; }
            set { m_DNI = value; }
        }
        private int? m_Tipo;
        public int? Tipo
        {
            get { return m_Tipo; }
            set { m_Tipo = value; }
        }
        private string m_Nombre;
        public string Nombre
        {
            get { return m_Nombre; }
            set { m_Nombre = value; }
        }
        private string m_ApellidoPaterno;
        public string ApellidoPaterno
        {
            get { return m_ApellidoPaterno; }
            set { m_ApellidoPaterno = value; }
        }
        private string m_ApellidoMaterno;
        public string ApellidoMaterno
        {
            get { return m_ApellidoMaterno; }
            set { m_ApellidoMaterno = value; }
        }
        private DateTime? m_FechaInscripcion;
        public DateTime? FechaInscripcion
        {
            get { return m_FechaInscripcion; }
            set { m_FechaInscripcion = value; }
        }
        private string m_Direccion;
        public string Direccion
        {
            get { return m_Direccion; }
            set { m_Direccion = value; }
        }
        private string m_CodigoUbigeo;
        public string CodigoUbigeo
        {
            get { return m_CodigoUbigeo; }
            set { m_CodigoUbigeo = value; }
        }

    }
}

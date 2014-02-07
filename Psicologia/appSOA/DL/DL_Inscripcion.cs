using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using EL;
using System.Data.SqlClient;

namespace DL
{
    public class DL_Inscripcion
    {

        private string _ConnectionString;
//        private static string _ConnectionString;
        private const string SP_INSCRIPCIONES_LISTAR = "SP_INSCRIPCIONES_LISTAR";

        public DL_Inscripcion()
        {
            Connection connection = new Connection(); 
            _ConnectionString = connection.ConnectionString;
        }

        private static EL_Inscripcion LlenarDatos(IDataRecord p_dr)
        {
            EL_Inscripcion i = new EL_Inscripcion();

            i.CodigoInscripcion = p_dr.GetInt32(0);
            if (p_dr[1] == Convert.DBNull)
                i.DNI = null;
            else
                i.DNI = p_dr.GetString(1);

            if (p_dr[2] == Convert.DBNull)
                i.Tipo = null;
            else
                i.Tipo = p_dr.GetInt32(2);

            if (p_dr[3] == Convert.DBNull)
                i.Nombre = null;
            else
                i.Nombre = p_dr.GetString(3);

            if (p_dr[4] == Convert.DBNull)
                i.ApellidoPaterno = null;
            else
                i.ApellidoPaterno = p_dr.GetString(4);

            if (p_dr[5] == Convert.DBNull)
                i.ApellidoMaterno = null;
            else
                i.ApellidoMaterno = p_dr.GetString(5);

            if (p_dr[6] == Convert.DBNull)
                i.FechaInscripcion = null;
            else
                i.FechaInscripcion = p_dr.GetDateTime(6);

            if (p_dr[7] == Convert.DBNull)
                i.Direccion = null;
            else
                i.Direccion = p_dr.GetString(7);

            if (p_dr[8] == Convert.DBNull)
                i.CodigoUbigeo = null;
            else
                i.CodigoUbigeo = p_dr.GetString(8);


            return i;
        }


        public List<EL_Inscripcion> Get_ListarDatos(Int32 P_CodigoInscripcion, string P_DNI, string P_Nombre, string P_ApellidoPaterno, string P_ApellidoMaterno)
        {

            List<EL_Inscripcion> coll = null;
            EL_Inscripcion i = null;

            SqlDataReader dr = null;
            SqlConnection con = null;

            coll = new List<EL_Inscripcion>();

            try
            {

                using (con = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(SP_INSCRIPCIONES_LISTAR, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        ///cmd.Parameters.Add(sqlParams);
                        cmd.Parameters.AddWithValue("@P_CodigoInscripcion", P_CodigoInscripcion);
                        cmd.Parameters.AddWithValue("@P_DNI", P_DNI);
                        cmd.Parameters.AddWithValue("@P_Nombre", P_Nombre);
                        cmd.Parameters.AddWithValue("@P_ApellidoPaterno", P_ApellidoPaterno);
                        cmd.Parameters.AddWithValue("@P_ApellidoMaterno", P_ApellidoMaterno);
                        cmd.Connection.Open();

                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            i = LlenarDatos(dr);
                            coll.Add(i);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null)
                {
                    if (!dr.IsClosed)
                        dr.Close();
                    dr.Dispose();
                    dr = null;
                }
                if (con != null)
                {
                    if (con.State != ConnectionState.Closed)
                        con.Close();
                    con.Dispose();
                    con = null;
                }
            }

            return coll;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appPsicologia
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtDNI.Text = "";
                Label3.Text = "";
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            // Instancia el WS en una variable
            wsInscripciones.wsInscripcion wsIns = new wsInscripciones.wsInscripcion();
            // El WS devuelve una lista pero con 1 registro, en una variable de tipo lista de la clase
            List<wsInscripciones.EL_Inscripcion> Lista = wsIns.Get_ListarDatos(txtDNI.Text).ToList();
            // Verificando si devolvio registros
            if (Lista != null && Lista.Count() > 0)
            {
                if (!string.IsNullOrEmpty(Lista[0].Nombre)) { Label3.Text = Lista[0].Nombre.ToString().Trim(); }
                if (!string.IsNullOrEmpty(Lista[0].ApellidoPaterno)) { Label3.Text = Label3.Text + " " + Lista[0].ApellidoPaterno.ToString().Trim(); }
                if (!string.IsNullOrEmpty(Lista[0].ApellidoMaterno)) { Label3.Text = Label3.Text + " " + Lista[0].ApellidoMaterno.ToString().Trim(); }
            }
            else
            {
                Label3.Text = "No existe el DNI, verificar!!!";
            }

        }
    }
}
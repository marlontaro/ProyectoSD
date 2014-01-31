using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using it.dominio;
using it.negocio;
public partial class _Default : System.Web.UI.Page
{
    Usuario oUsuario;
    IAdministracion oAdministracion;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["cCerrar"] != null)
            {
                Session.Remove("Usuario");
                Session.Clear();
            }

            if (Session["Usuario"] != null)
            {
                oUsuario = (Usuario)Session["Usuario"];

                lblParticipante.Text = oUsuario.Persona.Nombre + " " + oUsuario.Persona.ApellidoPaterno + " " + oUsuario.Persona.ApellidoMaterno;
                lblCorreo.Text = oUsuario.Persona.Correo;
            }
            else
            {
                Response.Redirect("~/WebLogin.aspx");
            }
        }
    }

   
}
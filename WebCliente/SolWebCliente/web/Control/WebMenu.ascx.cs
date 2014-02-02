using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using it.dominio;

public partial class Control_WebMenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Usuario oUsuario;

        if (Session["Usuario"] != null)
        {
            oUsuario = (Usuario)Session["Usuario"];

            radSeguridad.Visible = true;
            radUsuario.Visible = true;
            radTabla.Visible = true;
            radProceso.Visible = true;
        }
    }
}
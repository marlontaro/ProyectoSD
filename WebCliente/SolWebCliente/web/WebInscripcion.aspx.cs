using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using it.dominio;

public partial class WebInscripcion : System.Web.UI.Page
{
    Usuario oTUsuario;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Session["Usuario"] != null)
            {
                oTUsuario = (Usuario)Session["Usuario"]; 
                gvwPerfiles.Rebind();
            }
            else
            {
                lnkAgregar.Visible = false;
                pnlActivo.Visible = false;
                pnlInactivo.Visible = true;
                litSinConexion.Text =  ResolveClientUrl("~/");
            }
        }
    }

    protected void SqlLinqPerfiles_Selecting(object sender, Telerik.OpenAccess.Web.OpenAccessLinqDataSourceSelectEventArgs e)
    {
        using (DbContext db = new DbContext())
        {
            e.Result = db.InscripcionListar();
        }
    }

    protected void gvwPerfiles_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        if (e.CommandName == "Eliminar")
        { 
        
        }
    }
}
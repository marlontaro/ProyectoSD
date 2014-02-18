using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using it.dominio;
using it.web.util;

public partial class WebAprobacionDireccion : System.Web.UI.Page
{
    Usuario oTUsuario;
    Helper oHelper;

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
                pnlActivo.Visible = false;
                pnlInactivo.Visible = true;
                oHelper = new Helper();

                litSinConexion.Text = oHelper.DevuelveSinConexion();
            }
        }
    }

    protected void SqlLinqPerfiles_Selecting(object sender, Telerik.OpenAccess.Web.OpenAccessLinqDataSourceSelectEventArgs e)
    {
        if (Session["Usuario"] != null)
        {
            oTUsuario = (Usuario)Session["Usuario"];
            using (DbContext db = new DbContext())
            {
                e.Result = db.EvaluacionListar(3, oTUsuario.CodigoUsuario);
            }
        }
    }

    protected void gvwPerfiles_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {

    }
}
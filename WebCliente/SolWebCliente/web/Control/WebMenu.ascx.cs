using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using it.dominio;
using Telerik.Web.UI;
using it.web.util;

public partial class Control_WebMenu : System.Web.UI.UserControl
{
    Helper oHelper ;

    protected void Page_Load(object sender, EventArgs e)
    {
        Usuario oUsuario;
        oHelper= new Helper();

        if (Session["Usuario"] != null)
        {
            oUsuario = (Usuario)Session["Usuario"];
            
            radSeguridad.Visible = true;
            radUsuario.Visible = true;
            radTabla.Visible = true;
            radProceso.Visible = true;

            RadMenuItem procesoa = radProceso.FindItemByText("ProcesoA");
            Panel pnlInscripcion = (Panel)procesoa.FindControl("pnlInscripcion");
            Panel pnlAprobacionAcademica = (Panel)procesoa.FindControl("pnlAprobacionAcademica");
            Panel pnlAprobacionDireccion = (Panel)procesoa.FindControl("pnlAprobacionDireccion");
            Panel pnlMatricula = (Panel)procesoa.FindControl("pnlMatricula");

            if (oHelper.DevuelvePerfil("Administrador", oUsuario.Perfils)) {
                pnlInscripcion.Visible = true;
                pnlAprobacionAcademica.Visible = true;
                pnlAprobacionDireccion.Visible = true;
                pnlMatricula.Visible = true;
            }else 

            if (oHelper.DevuelvePerfil("Aprobador Academico", oUsuario.Perfils))
            {
                pnlInscripcion.Visible = false;
                pnlAprobacionAcademica.Visible = true;
                pnlAprobacionDireccion.Visible = false;
                pnlMatricula.Visible = false;
            }else 

            if (oHelper.DevuelvePerfil("Aprobador Director", oUsuario.Perfils))
            {
                pnlInscripcion.Visible = false;
                pnlAprobacionAcademica.Visible = false;
                pnlAprobacionDireccion.Visible = true;
                pnlMatricula.Visible = false;
            }
        }
    }

}
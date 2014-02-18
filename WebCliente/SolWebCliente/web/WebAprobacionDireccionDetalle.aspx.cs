using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using it.dominio;
using it.negocio;
using it.web.util;

public partial class WebAprobacionDireccionDetalle : System.Web.UI.Page
{
    Usuario oUsuario;
    IAdministracion oAdministracion;
    Helper oHelper;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Usuario"] != null)
            {
                if (Request.QueryString["nCode"] != null)
                {
                    int nCodigo = int.Parse(Request.QueryString["nCode"].ToString().Trim());
                    lblCodigo.Text = Request.QueryString["nCode"].ToString().Trim();

                    Evaluacion oEvaluacion = new Evaluacion();
                    InscripcionDetalle oDetalle = new InscripcionDetalle();

                    using (DbContext dbContext = new DbContext())
                    {
                        oEvaluacion = (from ent in dbContext.Evaluacions
                                       where ent.CodigoEvaluacion == nCodigo
                                       select ent).FirstOrDefault();
                    }

                    if (oEvaluacion != null)
                    {

                        if (oEvaluacion.CodigoEvaluacion != 0)
                        {
                            oDetalle = oEvaluacion.InscripcionDetalle;

                            txtDNI.Text = oDetalle.DNI;
                            txtNombre.Text = String.Format("{0} {1} {2}", oDetalle.Nombre, oDetalle.ApellidoPaterno, oDetalle.ApellidoMaterno);

                            if (oEvaluacion.Respuesta != null)
                            {
                                if (oEvaluacion.Respuesta.Value == 2)
                                {
                                    rbAceptado.Checked = true;
                                }
                                else if (oEvaluacion.Respuesta.Value == 3)
                                {
                                    rbNoAceptado.Checked = true;
                                }
                            }
                            txtObservacion.Text = oEvaluacion.Observacion;
                        }
                    }
                }
            }
        }
    }

    protected void lnkGuardar_Click(object sender, EventArgs e)
    {
        Evaluacion oEvaluacion = new Evaluacion();
        oEvaluacion.CodigoEvaluacion = int.Parse(lblCodigo.Text.Trim());

        if (rbAceptado.Checked == true)
        {
            oEvaluacion.Respuesta = 2;
        }
        else if (rbNoAceptado.Checked == true)
        {
            oEvaluacion.Respuesta = 2;
        }
        oEvaluacion.Observacion = txtObservacion.Text;

        using (DbContext dbContext = new DbContext())
        {
            Evaluacion oTEvaluacion = new Evaluacion();
            oTEvaluacion = (from ent in dbContext.Evaluacions
                            where ent.CodigoEvaluacion == oEvaluacion.CodigoEvaluacion
                            select ent).FirstOrDefault();

            oTEvaluacion.Respuesta = oEvaluacion.Respuesta;
            oTEvaluacion.Observacion = oEvaluacion.Observacion;
            dbContext.SaveChanges();
        }

    }
}
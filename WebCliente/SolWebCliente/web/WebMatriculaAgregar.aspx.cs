using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using it.dominio;
using it.negocio;
using it.web.util;

public partial class WebMatriculaAgregar : System.Web.UI.Page
{
    Usuario oUsuario;
    Administracion oAdministracion;
    Helper oHelper;

    #region Utiles
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Session["Usuario"] != null)
            {
                oUsuario = (Usuario)Session["Usuario"];
                ListarDepartamento();

                int nCodigoDetalle = 0;

                if (Request.QueryString["nCodigoInscripcion"] != null)
                {
                    nCodigoDetalle = int.Parse(Request.QueryString["nCodigoInscripcion"].ToString().Trim());

                    InscripcionDetalle oDetalle = new InscripcionDetalle();

                    if (nCodigoDetalle != 0) { 
                        using(DbContext dbContext= new DbContext()){
                            oDetalle = (from ent in dbContext.InscripcionDetalles
                                        where ent.CodigoInscripcionDetalle == nCodigoDetalle
                                        select ent).FirstOrDefault();
                        }

                        if (oDetalle != null) {

                            if (oDetalle.CodigoInscripcionDetalle != 0) {

                                //hijo
                                lblCodigo.Text = oDetalle.Inscripcion.CodigoInscripcion.ToString().Trim();
                                txtNombre.Text = oDetalle.Inscripcion.Nombre;
                                txtApellido.Text = oDetalle.Inscripcion.ApellidoPaterno + " " + oDetalle.Inscripcion.ApellidoMaterno;
                                txtDNI.Text = oDetalle.Inscripcion.DNI;

                                txtDireccion.Text = oDetalle.Inscripcion.Direccion;
                                txtTelefono.Text = oDetalle.Inscripcion.Telefono;
                                cboTipo.SelectedValue = oDetalle.Inscripcion.Tipo.ToString().Trim();

                                if (!String.IsNullOrEmpty(oDetalle.Inscripcion.CodigoUbigeo))
                                {
                                    String cDepartamento = oDetalle.Inscripcion.CodigoUbigeo.Substring(0, 2) + "0000";
                                    String cProvincia = oDetalle.Inscripcion.CodigoUbigeo.Substring(0, 4) + "00";
                                    cboDepartamento.SelectedValue = cDepartamento;
                                    cboDepartamento_SelectedIndexChanged(sender, e);

                                    cboProvincia.SelectedValue = cProvincia;
                                    cboProvincia_SelectedIndexChanged(sender, e);

                                    cboDistrito.SelectedValue = oDetalle.Inscripcion.CodigoUbigeo;
                                }


                                //hijo
                                txtHijoDni.Text = oDetalle.DNI;
                                txtHijoNombre.Text = oDetalle.Nombre;
                                txtHijoApellido.Text = oDetalle.ApellidoPaterno + " " + oDetalle.ApellidoMaterno;


                                cboEducacion.SelectedValue = oDetalle.Seccion.Educacion.ToString().Trim();
                                IList<Seccion> oListaTemSeccion = new List<Seccion>();
                                IList<Seccion> oListaSeccion = new List<Seccion>();

                                using (DbContext dbContext = new DbContext())
                                {
                                    oListaSeccion = (from ent in dbContext.Seccions
                                                     select ent).ToList();
                                }

                                oListaTemSeccion = new List<Seccion>();
                                oListaTemSeccion = (from ent in oListaSeccion
                                                    where ent.Educacion == oDetalle.Seccion.Educacion
                                                    select ent).ToList();

                                if (oListaTemSeccion.Count != 0)
                                {
                                    oListaTemSeccion.Insert(0, new Seccion() { CodigoSeccion = 0, Nombre = "Seleccione" });
                                }
                                else
                                {
                                    oListaTemSeccion.Add(new Seccion() { CodigoSeccion = 0, Nombre = "Seleccione" });
                                }

                                dtFecha.SelectedDate = oDetalle.FechaNacimiento;

                                if (oDetalle.Sexo == 1)
                                {
                                    rbHombre.Checked = true;
                                }
                                else if (oDetalle.Sexo == 2)
                                {
                                    rbMujer.Checked = true;
                                }
                                else
                                {
                                    rbOtro.Checked = true;
                                }

                                cboSeccion.DataSource = oListaTemSeccion;
                                cboSeccion.DataTextField = "Nombre";
                                cboSeccion.DataValueField = "CodigoSeccion";
                                cboSeccion.DataBind();

                                if (oDetalle.CodigoSeccion != 0)
                                {
                                    cboSeccion.SelectedValue = oDetalle.CodigoSeccion.ToString().Trim();
                                }

                            }
                        }
                    }
                }
            }
            else
            {
                //lnkAgregar.Visible = false;
                pnlActivo.Visible = false;
                pnlInactivo.Visible = true;
                oHelper = new Helper();

                litSinConexion.Text = oHelper.DevuelveSinConexion();
            }
        }
    }

    #endregion

    #region Utiles

    void ListarDepartamento()
    {
        IList<Ubigeo> oListaUbigeo = new List<Ubigeo>();
        oAdministracion = new Administracion();
        oListaUbigeo = oAdministracion.ListarDepartamento();

        oListaUbigeo.Insert(0, new Ubigeo() { CodigoUbigeo = "000000", Nombre = "SELECCIONE" });

        cboDepartamento.DataSource = oListaUbigeo;
        cboDepartamento.DataTextField = "Nombre";
        cboDepartamento.DataValueField = "CodigoUbigeo";
        cboDepartamento.DataBind();
    }

    #endregion

    #region Acciones

    protected void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
    {
        IList<Ubigeo> oListaUbigeo = new List<Ubigeo>();

        if (!cboDepartamento.SelectedValue.Trim().Equals("00000"))
        {
            oAdministracion = new Administracion();

            oListaUbigeo = oAdministracion.ListarProvincia(cboDepartamento.SelectedValue.Trim().Substring(0, 2));

            if (oListaUbigeo.Count != 0)
            {
                oListaUbigeo.Insert(0, new Ubigeo() { CodigoUbigeo = "000000", Nombre = "SELECCIONE" });
            }
            else
            {
                oListaUbigeo.Add(new Ubigeo() { CodigoUbigeo = "000000", Nombre = "SELECCIONE" });
            }
            cboProvincia.DataSource = oListaUbigeo;
            cboProvincia.DataTextField = "Nombre";
            cboProvincia.DataValueField = "CodigoUbigeo";
            cboProvincia.DataBind();


        }
    }

    protected void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
    {
        IList<Ubigeo> oListaUbigeo = new List<Ubigeo>();

        if (!cboDepartamento.SelectedValue.Trim().Equals("00000"))
        {
            oAdministracion = new Administracion();

            oListaUbigeo = oAdministracion.ListarDistrito(cboProvincia.SelectedValue.Trim().Substring(0, 4));

            if (oListaUbigeo.Count != 0)
            {
                oListaUbigeo.Insert(0, new Ubigeo() { CodigoUbigeo = "000000", Nombre = "SELECCIONE" });
            }
            else
            {
                oListaUbigeo.Add(new Ubigeo() { CodigoUbigeo = "000000", Nombre = "SELECCIONE" });
            }
            cboDistrito.DataSource = oListaUbigeo;
            cboDistrito.DataTextField = "Nombre";
            cboDistrito.DataValueField = "CodigoUbigeo";
            cboDistrito.DataBind();


        }
    }

    protected void cboEducacion_SelectedIndexChanged(object sender, EventArgs e)
    { 
        IList<Seccion> oListaSeccion = new List<Seccion>();

        if (!cboEducacion.SelectedValue.Trim().Equals("0"))
        {
            oAdministracion = new Administracion();

            oListaSeccion = oAdministracion.ListarSeccion(int.Parse(cboEducacion.SelectedValue.Trim()));

            cboSeccion.DataSource = oListaSeccion;
            cboSeccion.DataTextField = "Nombre";
            cboSeccion.DataValueField = "CodigoSeccion";
            cboSeccion.DataBind();
        }
    }
     
    protected void lnkGuardar_Click(object sender, EventArgs e)
    {

    }

    #endregion
}
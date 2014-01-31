using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using it.dominio;
using it.negocio;

public partial class WebInscripcionAgregar : System.Web.UI.Page
{
    Usuario oUsuario;
    IAdministracion oAdministracion;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

            if (Session["Usuario"] != null)
            {
                oUsuario = (Usuario)Session["Usuario"];
                ListarDepartamento();



              

            }
            else
            {
                Response.Redirect("~/WebLogin.aspx");
            }
        }
    }

    void ListarDepartamento()
    {
        IList<Ubigeo> oListaUbigeo = new List<Ubigeo>();
        oAdministracion = new Administracion();
        oListaUbigeo = oAdministracion.ListarDepartamento();        

        oListaUbigeo.Insert(0, new Ubigeo() { CodigoUbigeo = "000000" , Nombre="SELECCIONE"}); 

        cboDepartamento.DataSource = oListaUbigeo;
        cboDepartamento.DataTextField = "Nombre";
        cboDepartamento.DataValueField = "CodigoUbigeo";
        cboDepartamento.DataBind();
    }

    protected void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
    {
        IList<Ubigeo> oListaUbigeo = new List<Ubigeo>();

        if (!cboDepartamento.SelectedValue.Trim().Equals("00000")) {
            oAdministracion = new Administracion();

            oListaUbigeo = oAdministracion.ListarProvincia(cboDepartamento.SelectedValue.Trim().Substring(0,2));

            if (oListaUbigeo.Count != 0)
            {
                oListaUbigeo.Insert(0, new Ubigeo() { CodigoUbigeo = "000000", Nombre = "SELECCIONE" });
            }
            else {
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

        if (!cboDepartamento.SelectedValue.Trim().Equals("0"))
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
        int nSexo = 0;
        if (rbHombre.Checked == true) {
            nSexo = 1;
        }
        if (rbMujer.Checked == true)
        {
            nSexo = 2;
        }
        if (rbOtro.Checked == true)
        {
            nSexo = 3;
        }
        using (DbContext dbContext = new DbContext()) {
            Inscripcion oInscripcion = new Inscripcion();
            oInscripcion.DNI = txtDNI.Text;
            oInscripcion.Nombre = txtNombre.Text;
            oInscripcion.ApellidoPaterno = txtApellido.Text;
            oInscripcion.ApellidoMaterno = "";
            oInscripcion.Direccion = txtDireccion.Text;
            oInscripcion.CodigoUbigeo = cboDistrito.SelectedValue.Trim();
            oInscripcion.Tipo = int.Parse(cboTipo.SelectedValue.Trim());
            oInscripcion.FechaInscripcion = DateTime.Now;
            oInscripcion.Telefono = txtTelefono.Text;
            dbContext.Add(oInscripcion);
            dbContext.SaveChanges();
            InscripcionDetalle oDetalle = new InscripcionDetalle();
            oDetalle.CodigoInscripcion = oInscripcion.CodigoInscripcion;
            oDetalle.Nombre = txtHijoNombre.Text;
            oDetalle.ApellidoPaterno = txtHijoApellido.Text;
            oDetalle.ApellidoMaterno = "";
            oDetalle.DNI = txtHijoDni.Text;
            oDetalle.FechaNacimiento = dtFecha.SelectedDate.Value;
            oDetalle.CodigoSeccion = int.Parse(cboSeccion.SelectedValue);
            oDetalle.Sexo = nSexo;
            dbContext.Add(oDetalle);
            dbContext.SaveChanges();
        }
    }
}
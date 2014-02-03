using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using it.dominio;
using it.negocio;
using Telerik.Web.UI;
using it.web.util;

public partial class WebInscripcionAgregar : System.Web.UI.Page
{
    Usuario oUsuario;
    IAdministracion oAdministracion;
    Helper oHelper;

    #region Inicio
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

            if (Session["Usuario"] != null)
            {
                oUsuario = (Usuario)Session["Usuario"];
                ListarDepartamento();

                //nuevo
                IList<InscripcionDetalle> oListaDetalle = new List<InscripcionDetalle>();
                oListaDetalle.Add(new InscripcionDetalle() {
                        CodigoInscripcion = 1,
                        FechaNacimiento = DateTime.Now,
                        Seccion = new Seccion(),
                        Sexo =1
                });
                gridDetalle.DataSource = oListaDetalle;
                gridDetalle.DataBind();

                FormatearGrid(oListaDetalle);
              

            }
            else
            {
                lnkAgregar.Visible = false;
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

        oListaUbigeo.Insert(0, new Ubigeo() { CodigoUbigeo = "000000" , Nombre="SELECCIONE"}); 

        cboDepartamento.DataSource = oListaUbigeo;
        cboDepartamento.DataTextField = "Nombre";
        cboDepartamento.DataValueField = "CodigoUbigeo";
        cboDepartamento.DataBind();
    }

    private IList<InscripcionDetalle> ObtenerDetalle() { 

        IList<InscripcionDetalle> oListaDetalle = new List<InscripcionDetalle>();
        Label lblCodigo, lblNro;
        TextBox txtHijoDni, txtHijoNombre, txtHijoApellido;
        RadDatePicker dtFecha;
        RadioButton rbHombre, rbMujer, rbOtro;
        DropDownList cboEducacion, cboSeccion;
        int nSexo = 0;

        for (int i = 0; i < gridDetalle.Items.Count; i++)
        {
            lblCodigo = (Label)gridDetalle.Items[i].FindControl("lblCodigo");
            lblNro = (Label)gridDetalle.Items[i].FindControl("lblNro");
            
            txtHijoDni = (TextBox)gridDetalle.Items[i].FindControl("txtHijoDni");
            txtHijoNombre = (TextBox)gridDetalle.Items[i].FindControl("txtHijoNombre");
            txtHijoApellido = (TextBox)gridDetalle.Items[i].FindControl("txtHijoApellido");

            dtFecha = (RadDatePicker)gridDetalle.Items[i].FindControl("dtFecha");
            
            rbHombre = (RadioButton)gridDetalle.Items[i].FindControl("rbHombre");
            rbMujer = (RadioButton)gridDetalle.Items[i].FindControl("rbMujer");
            rbOtro = (RadioButton)gridDetalle.Items[i].FindControl("rbOtro");

            cboEducacion = (DropDownList)gridDetalle.Items[i].FindControl("cboEducacion");
            cboSeccion = (DropDownList)gridDetalle.Items[i].FindControl("cboSeccion");
            
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

            oListaDetalle.Add(new InscripcionDetalle()
            {
                CodigoInscripcionDetalle = int.Parse(lblCodigo.Text),
                CodigoInscripcion = int.Parse(lblNro.Text),
                DNI = txtHijoDni.Text,
                Nombre = txtHijoNombre.Text,
                ApellidoPaterno = txtHijoApellido.Text,
                ApellidoMaterno = "", //se me paso =P
                FechaNacimiento = dtFecha.SelectedDate.Value,
                Sexo = nSexo,
                CodigoSeccion = int.Parse(cboSeccion.SelectedValue.Trim()),
                Seccion = new Seccion() { 
                    Educacion = int.Parse(cboEducacion.SelectedValue.Trim())
                }
            });
        }
        return oListaDetalle;
    }

    private void FormatearGrid(IList<InscripcionDetalle> oLista) {
        IList<Seccion> oListaSeccion = new List<Seccion>();
        IList<Seccion> oListaTemSeccion;
        InscripcionDetalle oDetalle;
        RadioButton rbHombre, rbMujer, rbOtro;
        DropDownList cboEducacion, cboSeccion;
        

        using (DbContext dbContext = new DbContext()) {
            oListaSeccion = (from ent in dbContext.Seccions
                             select ent).ToList();
        }

        for (int i = 0; i < gridDetalle.Items.Count; i++)
        {
            oDetalle = oLista[i];

            rbHombre = (RadioButton)gridDetalle.Items[i].FindControl("rbHombre");
            rbMujer = (RadioButton)gridDetalle.Items[i].FindControl("rbMujer");
            rbOtro = (RadioButton)gridDetalle.Items[i].FindControl("rbOtro");
            cboEducacion = (DropDownList)gridDetalle.Items[i].FindControl("cboEducacion");
            cboSeccion = (DropDownList)gridDetalle.Items[i].FindControl("cboSeccion");

            if (oDetalle.Sexo == 1) {
                rbHombre.Checked = true;
            }
            else if (oDetalle.Sexo == 2)
            {
                rbMujer.Checked = true;
            }
            else {
                rbOtro.Checked = true;
            }

            cboEducacion.SelectedValue = oDetalle.Seccion.Educacion.ToString().Trim();
            oListaTemSeccion = new List<Seccion>();
            oListaTemSeccion = (from ent in oListaSeccion
                                where ent.Educacion == oDetalle.Seccion.Educacion
                                select ent).ToList();

            if (oListaTemSeccion.Count != 0)
            {
                oListaTemSeccion.Insert(0, new Seccion() { CodigoSeccion = 0, Nombre = "Seleccione" }); 
            }
            else {
                oListaTemSeccion.Add(new Seccion() { CodigoSeccion = 0, Nombre = "Seleccione" });
            }

            cboSeccion.DataSource = oListaTemSeccion;
            cboSeccion.DataTextField = "Nombre";
            cboSeccion.DataValueField = "CodigoSeccion";
            cboSeccion.DataBind();

            if (oDetalle.CodigoSeccion != 0) {
                cboSeccion.SelectedValue = oDetalle.CodigoSeccion.ToString().Trim();
            }
        }
    }
    
    #endregion

    #region Acciones

    protected void lnkBuscarReniec_Click(object sender, EventArgs e)
    {
        //ServicioCloud.NewWebServiceClient oCliente = new ServicioCloud.NewWebServiceClient();
        //lblDNI.Text =  oCliente.hello(txtDNI.Text);
        //oCliente = null;
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
        GridDataItem item = (GridDataItem)(sender as DropDownList).NamingContainer;
        DropDownList cboEducacion = (DropDownList)item.FindControl("cboEducacion");
        DropDownList cboSeccion = (DropDownList)item.FindControl("cboSeccion");
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

    protected void lnkBuscarMinedu_Click(object sender, EventArgs e)
    {

        GridDataItem item = (GridDataItem)(sender as LinkButton).NamingContainer;
        TextBox txtHijoDni = (TextBox)item.FindControl("txtHijoDni");
        TextBox txtHijoNombre = (TextBox)item.FindControl("txtHijoNombre");
        TextBox txtHijoApellido = (TextBox)item.FindControl("txtHijoApellido");
        RadDatePicker dtFecha = (RadDatePicker)item.FindControl("dtFecha");

        RadioButton rbHombre = (RadioButton)item.FindControl("rbHombre");
        RadioButton rbMujer = (RadioButton)item.FindControl("rbMujer");
        RadioButton rbOtro = (RadioButton)item.FindControl("rbOtro");
        DropDownList cboEducacion = (DropDownList)item.FindControl("cboEducacion");
        DropDownList cboSeccion = (DropDownList)item.FindControl("cboSeccion");
        Literal LitEduError = (Literal)item.FindControl("LitEduError");
        ServicioMinEdu.DatosEstudianteClient oServicio = new ServicioMinEdu.DatosEstudianteClient();
        ServicioMinEdu.Alumno oAlumno = new ServicioMinEdu.Alumno();
        oAlumno = oServicio.ObtenerAlumno(txtHijoDni.Text.Trim());

        
        
        if (oAlumno != null)
        {
            if (oAlumno.Nombre != null)
            {
                LitEduError.Text = "";
                txtHijoNombre.Text = oAlumno.Nombre;
                txtHijoApellido.Text = oAlumno.ApellidoPaterno + " " + oAlumno.ApellidoMaterno;
                dtFecha.SelectedDate = DateTime.Parse(oAlumno.FechaNacimiento);

                if (oAlumno.Sexo.Equals("Hombre"))
                {
                    rbHombre.Checked = true;
                }
                else if (oAlumno.Sexo.Equals("Mujer"))
                {
                    rbMujer.Checked = true;
                }
                else
                {
                    rbOtro.Checked = true;
                }

                if (oAlumno.Educacion.Equals("Inicial"))
                {
                    cboEducacion.SelectedValue = "1";
                }
                else if (oAlumno.Educacion.Equals("Primaria"))
                {
                    cboEducacion.SelectedValue = "2";
                }
                else if (oAlumno.Educacion.Equals("Secundaria"))
                {
                    cboEducacion.SelectedValue = "3";
                }

                IList<Seccion> oListaSeccion = new List<Seccion>();

                oAdministracion = new Administracion();

                oListaSeccion = oAdministracion.ListarSeccion(int.Parse(cboEducacion.SelectedValue.Trim()));

                cboSeccion.DataSource = oListaSeccion;
                cboSeccion.DataTextField = "Nombre";
                cboSeccion.DataValueField = "CodigoSeccion";
                cboSeccion.DataBind();

                foreach (ListItem oItem in cboSeccion.Items)
                {
                    if (oItem.Text.Equals(oAlumno.Grado.Trim(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        oItem.Selected = true;
                    }
                }
            }
            else { 
                //no exite 
                oHelper = new Helper();
                LitEduError.Text = oHelper.DevuelveHtmlError("<strong>Error</strong> No Existe Alumno en la Base de Datos de Siagie");
            }
        }
    }
    
    protected void gridDetalle_ItemCreated(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridDataItem)
        {
            GridDataItem dataItem = (GridDataItem)e.Item;
            LinkButton lnkBuscarMinedu = (LinkButton)dataItem.FindControl("lnkBuscarMinedu");
            DropDownList cboEducacion = (DropDownList)dataItem.FindControl("cboEducacion");
            cboEducacion.SelectedIndexChanged += new EventHandler(cboEducacion_SelectedIndexChanged);
            lnkBuscarMinedu.Click += new EventHandler(lnkBuscarMinedu_Click);
        }
    }

    protected void gridDetalle_ItemCommand(object sender, GridCommandEventArgs e)
    {
        if (e.CommandName == "Eliminar")
        {
            int nNro = Convert.ToInt32(e.CommandArgument);
            IList<InscripcionDetalle> oListaDetalle = new List<InscripcionDetalle>();
            oListaDetalle = ObtenerDetalle();
            oListaDetalle.RemoveAt(nNro - 1);
            gridDetalle.DataSource = oListaDetalle;
            gridDetalle.DataBind();

            FormatearGrid(oListaDetalle);
        }
    }

    protected void lnkAgregar_Click(object sender, EventArgs e)
    {
        IList<InscripcionDetalle> oListaDetalle = new List<InscripcionDetalle>();
        oListaDetalle = ObtenerDetalle();
        oListaDetalle.Add(new InscripcionDetalle()
        {
            CodigoInscripcion = oListaDetalle.Count+1,
            FechaNacimiento = DateTime.Now,
            Seccion = new Seccion(),
            Sexo = 1
        });

        gridDetalle.DataSource = oListaDetalle;
        gridDetalle.DataBind();
        FormatearGrid(oListaDetalle);
    }
   
    protected void lnkGuardar_Click(object sender, EventArgs e)
    {
        //ServiceReference1.DatosEstudianteClient oServicio = new ServiceReference1.DatosEstudianteClient();
        //oServicio.ObtenerNotas("");
        //ServiceReference1.DetalleNota a = new ServiceReference1.DetalleNota();
        
        //int nSexo = 0;
        //if (rbHombre.Checked == true) {
        //    nSexo = 1;
        //}
        //if (rbMujer.Checked == true)
        //{
        //    nSexo = 2;
        //}
        //if (rbOtro.Checked == true)
        //{
        //    nSexo = 3;
        //}
        //using (DbContext dbContext = new DbContext()) {
        //    Inscripcion oInscripcion = new Inscripcion();
        //    oInscripcion.DNI = txtDNI.Text;
        //    oInscripcion.Nombre = txtNombre.Text;
        //    oInscripcion.ApellidoPaterno = txtApellido.Text;
        //    oInscripcion.ApellidoMaterno = "";
        //    oInscripcion.Direccion = txtDireccion.Text;
        //    oInscripcion.CodigoUbigeo = cboDistrito.SelectedValue.Trim();
        //    oInscripcion.Tipo = int.Parse(cboTipo.SelectedValue.Trim());
        //    oInscripcion.FechaInscripcion = DateTime.Now;
        //    oInscripcion.Telefono = txtTelefono.Text;
        //    dbContext.Add(oInscripcion);
        //    dbContext.SaveChanges();
        //    InscripcionDetalle oDetalle = new InscripcionDetalle();
        //    oDetalle.CodigoInscripcion = oInscripcion.CodigoInscripcion;
        //    oDetalle.Nombre = txtHijoNombre.Text;
        //    oDetalle.ApellidoPaterno = txtHijoApellido.Text;
        //    oDetalle.ApellidoMaterno = "";
        //    oDetalle.DNI = txtHijoDni.Text;
        //    oDetalle.FechaNacimiento = dtFecha.SelectedDate.Value;
        //    oDetalle.CodigoSeccion = int.Parse(cboSeccion.SelectedValue);
        //    oDetalle.Sexo = nSexo;
        //    dbContext.Add(oDetalle);
        //    dbContext.SaveChanges();
        //}
    }

    #endregion
    
}
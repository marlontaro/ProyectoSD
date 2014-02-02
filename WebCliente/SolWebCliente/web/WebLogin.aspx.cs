using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using it.dominio;

public partial class WebLogin : System.Web.UI.Page
{
    Usuario oUsuario;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        String usuario = txtUsuario.Text;
        String pwd = txtContra.Text;
        String eror = "";

        pnlError.Visible = false;
        if (usuario.Trim().Length == 0)
        {
            eror += "<li>Usuario obligatorio</li>";
        }
        if (pwd.Trim().Length == 0)
        {
            eror += "<li>Contraseña obligatorio</li>";
        }

        if (eror.Trim().Length != 0)
        {
            pnlError.Visible = true;
            litError.Text = "<ul>" + eror + "/<ul>";
        }
        else
        {
            using (DbContext dbContext = new DbContext())
            {
                oUsuario = new Usuario();
                oUsuario = (from usuario1 in dbContext.Usuarios
                            where usuario1.Nombre == usuario.Trim() &&
                                  usuario1.Contrasenia == txtContra.Text.Trim()
                            select usuario1).FirstOrDefault();

                if (oUsuario != null)
                {
                    if (oUsuario.CodigoUsuario != 0)
                    {
                        //List<Perfil> listaPerfilUsu = new List<Perfil>();
                        Session["Usuario"] = oUsuario;
                        Response.Redirect("~/Default.aspx");
                    }
                    else
                    {
                        eror = "Usuario o Contraseña invalido";
                        pnlError.Visible = true;
                        litError.Text = eror;
                    }
                }
                else
                {
                    eror = "Usuario invalido";
                    pnlError.Visible = true;
                    litError.Text = eror;
                }

            }

        }
    }

}
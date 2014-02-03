using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using it.dominio;

/// <summary>
/// Descripción breve de Helper
/// </summary>
namespace it.web.util
{
    public class Helper
    {
         

        public string DevuelveSinConexion()
        {
            
            string cMensaje = "";
            cMensaje = "<ul><li>";
            cMensaje += "Usted no ha iniciado sesion, <A HREF=\"Default.aspx\">inicie sesion</A>.";
            cMensaje += "</li></ul>";
            return cMensaje;
        }

        public string DevuelveSinCodigo()
        {
            string cMensaje = "";
            cMensaje += "Código invalido.";
            return cMensaje;
        }

        public string DevuelveSinPermiso()
        {
            string cMensaje = "";

            cMensaje = "<ul><li>";
            cMensaje += "Usted no tiene permiso para esta página.";
            cMensaje += "</li></ul>";

            return cMensaje;
        }

        public string DevuelveFormatoWeb(String cCadena)
        { 
            string cResultado = "";
            if (cCadena.Trim().Length != 0)
            {
                cResultado = cCadena.Replace(".", ".</li><li>");
                cResultado = cResultado.Replace("|", ".");
                cResultado = cResultado.Substring(0, cResultado.Trim().Length - 4);

                cResultado = "<ul><li>" + cResultado + "</ul>";
            }
            return cResultado;
        }

        public bool ValidarCorreo(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }

        public String ReplaceCaracter(String cTexto)
        {
            cTexto = cTexto.Replace("[ ]", "_");
            cTexto = cTexto.Replace(" ", "_");
            cTexto = cTexto.Replace(":", "");
            cTexto = cTexto.Replace("|", "");
            cTexto = cTexto.Replace("/", "");
            cTexto = cTexto.Replace("*", "");
            cTexto = cTexto.Replace("?", "");
            cTexto = cTexto.Replace("¿", "");

            cTexto = cTexto.Replace("¡", "");
            cTexto = cTexto.Replace("!", "");

            cTexto = cTexto.Replace("'", "");
            cTexto = cTexto.Replace("\"", "");
            cTexto = cTexto.Replace(",", "");
            cTexto = cTexto.Replace(".", "");
            cTexto = cTexto.Replace("'", "");
            cTexto = cTexto.Replace("]", "");
            cTexto = cTexto.Replace("[", "");
            cTexto = cTexto.Replace("}", "");
            cTexto = cTexto.Replace("{", "");

            cTexto = cTexto.Replace("á", "a");
            cTexto = cTexto.Replace("Á", "A");

            cTexto = cTexto.Replace("é", "e");
            cTexto = cTexto.Replace("É", "E");

            cTexto = cTexto.Replace("í", "i");
            cTexto = cTexto.Replace("Í", "I");

            cTexto = cTexto.Replace("ó", "o");
            cTexto = cTexto.Replace("Ó", "O");

            cTexto = cTexto.Replace("ú", "u");
            cTexto = cTexto.Replace("Ú", "U");

            return cTexto;

        }

        public string DevuelveHtmlError(String cMensaje) {
            string cHtml = "";
            cHtml = String.Format("<div class=\"alert alert-error\">{0}</div>",cMensaje);
            return cHtml;
        }
    }
}
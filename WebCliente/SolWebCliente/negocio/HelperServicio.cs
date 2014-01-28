using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace it.negocio
{
    public class HelperServicio
    {
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
    }
}

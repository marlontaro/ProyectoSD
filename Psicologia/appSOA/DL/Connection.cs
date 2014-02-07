using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Web;

namespace DL
{
    public sealed class Connection
    {

        private const string ASPNetConnectionString = "ConnectionString";
        //        private const string ASPNetConnectionString = "Dat_Expedientes.Properties.Settings.ConnectionString";
        private string connectionString;
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            private set
            {
                connectionString = value;
            }
        }

        public Connection()
        {
            ConnectionString = System.Web.Configuration.WebConfigurationManager.
                ConnectionStrings[ASPNetConnectionString].ConnectionString;
        }

    }
}

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using it.dominio;


namespace it.dominio	
{
	public partial class Persona
	{
		private int _codigoPersona;
		public virtual int CodigoPersona 
		{ 
		    get
		    {
		        return this._codigoPersona;
		    }
		    set
		    {
		        this._codigoPersona = value;
		    }
		}
		
		private string _nombre;
		public virtual string Nombre 
		{ 
		    get
		    {
		        return this._nombre;
		    }
		    set
		    {
		        this._nombre = value;
		    }
		}
		
		private string _apellidoPaterno;
		public virtual string ApellidoPaterno 
		{ 
		    get
		    {
		        return this._apellidoPaterno;
		    }
		    set
		    {
		        this._apellidoPaterno = value;
		    }
		}
		
		private string _correo;
		public virtual string Correo 
		{ 
		    get
		    {
		        return this._correo;
		    }
		    set
		    {
		        this._correo = value;
		    }
		}
		
		private string _apellidoMaterno;
		public virtual string ApellidoMaterno 
		{ 
		    get
		    {
		        return this._apellidoMaterno;
		    }
		    set
		    {
		        this._apellidoMaterno = value;
		    }
		}
		
		private IList<Usuario> _usuarios = new List<Usuario>();
		public virtual IList<Usuario> Usuarios 
		{ 
		    get
		    {
		        return this._usuarios;
		    }
		}
		
		private Personal _personal;
		public virtual Personal Personal 
		{ 
		    get
		    {
		        return this._personal;
		    }
		    set
		    {
		        this._personal = value;
		    }
		}
		
		private Padre _padre;
		public virtual Padre Padre 
		{ 
		    get
		    {
		        return this._padre;
		    }
		    set
		    {
		        this._padre = value;
		    }
		}
		
		private Alumno _alumno;
		public virtual Alumno Alumno 
		{ 
		    get
		    {
		        return this._alumno;
		    }
		    set
		    {
		        this._alumno = value;
		    }
		}
		
	}
}

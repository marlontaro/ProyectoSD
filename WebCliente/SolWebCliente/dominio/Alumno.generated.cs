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
	public partial class Alumno
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
		
		private string _dNI;
		public virtual string DNI 
		{ 
		    get
		    {
		        return this._dNI;
		    }
		    set
		    {
		        this._dNI = value;
		    }
		}
		
		private DateTime? _fechaNacimiento;
		public virtual DateTime? FechaNacimiento 
		{ 
		    get
		    {
		        return this._fechaNacimiento;
		    }
		    set
		    {
		        this._fechaNacimiento = value;
		    }
		}
		
		private int? _sexo;
		public virtual int? Sexo 
		{ 
		    get
		    {
		        return this._sexo;
		    }
		    set
		    {
		        this._sexo = value;
		    }
		}
		
		private Persona _persona;
		public virtual Persona Persona 
		{ 
		    get
		    {
		        return this._persona;
		    }
		    set
		    {
		        this._persona = value;
		    }
		}
		
		private IList<AlumnoPeriodo> _alumnoPeriodos = new List<AlumnoPeriodo>();
		public virtual IList<AlumnoPeriodo> AlumnoPeriodos 
		{ 
		    get
		    {
		        return this._alumnoPeriodos;
		    }
		}
		
	}
}

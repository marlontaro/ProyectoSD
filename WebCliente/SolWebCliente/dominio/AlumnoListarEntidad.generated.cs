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


namespace it.dominio	
{
	public partial class AlumnoListarEntidad
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
		
		private string _alumno;
		public virtual string Alumno 
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
		
		private int _periodo;
		public virtual int Periodo 
		{ 
		    get
		    {
		        return this._periodo;
		    }
		    set
		    {
		        this._periodo = value;
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
		
		private string _sexo;
		public virtual string Sexo 
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
		
		private string _educacion;
		public virtual string Educacion 
		{ 
		    get
		    {
		        return this._educacion;
		    }
		    set
		    {
		        this._educacion = value;
		    }
		}
		
		private string _seccion;
		public virtual string Seccion 
		{ 
		    get
		    {
		        return this._seccion;
		    }
		    set
		    {
		        this._seccion = value;
		    }
		}
		
	}
}

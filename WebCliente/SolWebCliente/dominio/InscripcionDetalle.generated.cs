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
	public partial class InscripcionDetalle
	{
		private int _codigoInscripcion;
		public virtual int CodigoInscripcion 
		{ 
		    get
		    {
		        return this._codigoInscripcion;
		    }
		    set
		    {
		        this._codigoInscripcion = value;
		    }
		}
		
		private int _codigoInscripcionDetalle;
		public virtual int CodigoInscripcionDetalle 
		{ 
		    get
		    {
		        return this._codigoInscripcionDetalle;
		    }
		    set
		    {
		        this._codigoInscripcionDetalle = value;
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
		
		private DateTime _fechaNacimiento;
		public virtual DateTime FechaNacimiento 
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
		
		private int _sexo;
		public virtual int Sexo 
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
		
		private int _codigoSeccion;
		public virtual int CodigoSeccion 
		{ 
		    get
		    {
		        return this._codigoSeccion;
		    }
		    set
		    {
		        this._codigoSeccion = value;
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
		
		private Seccion _seccion;
		public virtual Seccion Seccion 
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
		
		private Inscripcion _inscripcion;
		public virtual Inscripcion Inscripcion 
		{ 
		    get
		    {
		        return this._inscripcion;
		    }
		    set
		    {
		        this._inscripcion = value;
		    }
		}
		
		private IList<Evaluacion> _evaluacions = new List<Evaluacion>();
		public virtual IList<Evaluacion> Evaluacions 
		{ 
		    get
		    {
		        return this._evaluacions;
		    }
		}
		
	}
}

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
	public partial class Evaluacion
	{
		private int _codigoEvaluacion;
		public virtual int CodigoEvaluacion 
		{ 
		    get
		    {
		        return this._codigoEvaluacion;
		    }
		    set
		    {
		        this._codigoEvaluacion = value;
		    }
		}
		
		private int? _tipo;
		public virtual int? Tipo 
		{ 
		    get
		    {
		        return this._tipo;
		    }
		    set
		    {
		        this._tipo = value;
		    }
		}
		
		private DateTime? _fecha;
		public virtual DateTime? Fecha 
		{ 
		    get
		    {
		        return this._fecha;
		    }
		    set
		    {
		        this._fecha = value;
		    }
		}
		
		private long? _hora;
		public virtual long? Hora 
		{ 
		    get
		    {
		        return this._hora;
		    }
		    set
		    {
		        this._hora = value;
		    }
		}
		
		private string _evaluador;
		public virtual string Evaluador 
		{ 
		    get
		    {
		        return this._evaluador;
		    }
		    set
		    {
		        this._evaluador = value;
		    }
		}
		
		private int? _respuesta;
		public virtual int? Respuesta 
		{ 
		    get
		    {
		        return this._respuesta;
		    }
		    set
		    {
		        this._respuesta = value;
		    }
		}
		
		private string _observacion;
		public virtual string Observacion 
		{ 
		    get
		    {
		        return this._observacion;
		    }
		    set
		    {
		        this._observacion = value;
		    }
		}
		
		private int? _codigoUsuario;
		public virtual int? CodigoUsuario 
		{ 
		    get
		    {
		        return this._codigoUsuario;
		    }
		    set
		    {
		        this._codigoUsuario = value;
		    }
		}
		
		private int? _codigoInscripcionDetalle;
		public virtual int? CodigoInscripcionDetalle 
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
		
		private int? _codigoAlumnoPeriodo;
		public virtual int? CodigoAlumnoPeriodo 
		{ 
		    get
		    {
		        return this._codigoAlumnoPeriodo;
		    }
		    set
		    {
		        this._codigoAlumnoPeriodo = value;
		    }
		}
		
		private Usuario _usuario;
		public virtual Usuario Usuario 
		{ 
		    get
		    {
		        return this._usuario;
		    }
		    set
		    {
		        this._usuario = value;
		    }
		}
		
		private InscripcionDetalle _inscripcionDetalle;
		public virtual InscripcionDetalle InscripcionDetalle 
		{ 
		    get
		    {
		        return this._inscripcionDetalle;
		    }
		    set
		    {
		        this._inscripcionDetalle = value;
		    }
		}
		
		private AlumnoPeriodo _alumnoPeriodo;
		public virtual AlumnoPeriodo AlumnoPeriodo 
		{ 
		    get
		    {
		        return this._alumnoPeriodo;
		    }
		    set
		    {
		        this._alumnoPeriodo = value;
		    }
		}
		
	}
}
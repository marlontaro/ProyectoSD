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
	public partial class Periodo
	{
		private int _codigoPeriodo;
		public virtual int CodigoPeriodo 
		{ 
		    get
		    {
		        return this._codigoPeriodo;
		    }
		    set
		    {
		        this._codigoPeriodo = value;
		    }
		}
		
		private int _anio;
		public virtual int Anio 
		{ 
		    get
		    {
		        return this._anio;
		    }
		    set
		    {
		        this._anio = value;
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

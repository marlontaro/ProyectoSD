﻿#pragma warning disable 1591
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
	public partial class DbContext : OpenAccessContext, IDbContextUnitOfWork
	{
		private static string connectionStringName = @"BDAlumnoConexion";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
		
			
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("DbContext.rlinq");
	
		public DbContext()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public DbContext(string connection)
			:base(connection, backend, metadataSource)
		{ }
	
		public DbContext(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public DbContext(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public DbContext(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<Usuario> Usuarios 
		{
	    	get
	    	{
	        	return this.GetAll<Usuario>();
	    	}
		}
		
		public IQueryable<Ubigeo> Ubigeos 
		{
	    	get
	    	{
	        	return this.GetAll<Ubigeo>();
	    	}
		}
		
		public IQueryable<Seccion> Seccions 
		{
	    	get
	    	{
	        	return this.GetAll<Seccion>();
	    	}
		}
		
		public IQueryable<Personal> Personals 
		{
	    	get
	    	{
	        	return this.GetAll<Personal>();
	    	}
		}
		
		public IQueryable<Persona> Personas 
		{
	    	get
	    	{
	        	return this.GetAll<Persona>();
	    	}
		}
		
		public IQueryable<Periodo> Periodos 
		{
	    	get
	    	{
	        	return this.GetAll<Periodo>();
	    	}
		}
		
		public IQueryable<Perfil> Perfils 
		{
	    	get
	    	{
	        	return this.GetAll<Perfil>();
	    	}
		}
		
		public IQueryable<Padre> Padres 
		{
	    	get
	    	{
	        	return this.GetAll<Padre>();
	    	}
		}
		
		public IQueryable<InscripcionDetalle> InscripcionDetalles 
		{
	    	get
	    	{
	        	return this.GetAll<InscripcionDetalle>();
	    	}
		}
		
		public IQueryable<Inscripcion> Inscripcions 
		{
	    	get
	    	{
	        	return this.GetAll<Inscripcion>();
	    	}
		}
		
		public IQueryable<Evaluacion> Evaluacions 
		{
	    	get
	    	{
	        	return this.GetAll<Evaluacion>();
	    	}
		}
		
		public IQueryable<CatalogoEstado> CatalogoEstados 
		{
	    	get
	    	{
	        	return this.GetAll<CatalogoEstado>();
	    	}
		}
		
		public IQueryable<AlumnoPeriodo> AlumnoPeriodos 
		{
	    	get
	    	{
	        	return this.GetAll<AlumnoPeriodo>();
	    	}
		}
		
		public IQueryable<Alumno> Alumnos 
		{
	    	get
	    	{
	        	return this.GetAll<Alumno>();
	    	}
		}
		
		public IEnumerable<it.dominio.InscripcionListarEntidad> InscripcionListar()
		{
			IEnumerable<it.dominio.InscripcionListarEntidad> queryResult = this.ExecuteQuery<it.dominio.InscripcionListarEntidad>("[usp_InscripcionListar]", CommandType.StoredProcedure);
	        
	    	return queryResult;
		}
		
		public IEnumerable<it.dominio.EvaluacionListarEntidad> EvaluacionListar(int? tipo, int? codigoUsuario)
		{
			OAParameter parameterTipo = new OAParameter();
			parameterTipo.ParameterName = "Tipo";
			if(tipo.HasValue)
			{
				parameterTipo.Value = tipo.Value;
			}
			else
			{
				parameterTipo.DbType = DbType.Int32;		
				parameterTipo.Value = DBNull.Value;
			}

			OAParameter parameterCodigoUsuario = new OAParameter();
			parameterCodigoUsuario.ParameterName = "CodigoUsuario";
			if(codigoUsuario.HasValue)
			{
				parameterCodigoUsuario.Value = codigoUsuario.Value;
			}
			else
			{
				parameterCodigoUsuario.DbType = DbType.Int32;		
				parameterCodigoUsuario.Value = DBNull.Value;
			}

			IEnumerable<it.dominio.EvaluacionListarEntidad> queryResult = this.ExecuteQuery<it.dominio.EvaluacionListarEntidad>("[usp_EvaluacionListar]", CommandType.StoredProcedure, parameterTipo, parameterCodigoUsuario);
	        
	    	return queryResult;
		}
		
		public IEnumerable<it.dominio.AlumnoListarEntidad> AlumnoListar(int? anio)
		{
			OAParameter parameterAnio = new OAParameter();
			parameterAnio.ParameterName = "Anio";
			if(anio.HasValue)
			{
				parameterAnio.Value = anio.Value;
			}
			else
			{
				parameterAnio.DbType = DbType.Int32;		
				parameterAnio.Value = DBNull.Value;
			}

			IEnumerable<it.dominio.AlumnoListarEntidad> queryResult = this.ExecuteQuery<it.dominio.AlumnoListarEntidad>("[usp_AlumnoListar]", CommandType.StoredProcedure, parameterAnio);
	        
	    	return queryResult;
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MsSql";
			backend.ProviderName = "System.Data.SqlClient";
			return backend;
		}
	}

	public interface IDbContextUnitOfWork : IUnitOfWork
	{
		IQueryable<Usuario> Usuarios 
		{ 
			get;
		}

		IQueryable<Ubigeo> Ubigeos 
		{ 
			get;
		}

		IQueryable<Seccion> Seccions 
		{ 
			get;
		}

		IQueryable<Personal> Personals 
		{ 
			get;
		}

		IQueryable<Persona> Personas 
		{ 
			get;
		}

		IQueryable<Periodo> Periodos 
		{ 
			get;
		}

		IQueryable<Perfil> Perfils 
		{ 
			get;
		}

		IQueryable<Padre> Padres 
		{ 
			get;
		}

		IQueryable<InscripcionDetalle> InscripcionDetalles 
		{ 
			get;
		}

		IQueryable<Inscripcion> Inscripcions 
		{ 
			get;
		}

		IQueryable<Evaluacion> Evaluacions 
		{ 
			get;
		}

		IQueryable<CatalogoEstado> CatalogoEstados 
		{ 
			get;
		}

		IQueryable<AlumnoPeriodo> AlumnoPeriodos 
		{ 
			get;
		}

		IQueryable<Alumno> Alumnos 
		{ 
			get;
		}

		IEnumerable<it.dominio.InscripcionListarEntidad> InscripcionListar();

		IEnumerable<it.dominio.EvaluacionListarEntidad> EvaluacionListar(int? tipo, int? codigoUsuario);

		IEnumerable<it.dominio.AlumnoListarEntidad> AlumnoListar(int? anio);

	}
}
#pragma warning restore 1591


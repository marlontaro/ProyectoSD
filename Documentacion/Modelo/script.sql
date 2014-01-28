use master 
go

create database BDAlumno
go

use BDAlumno
go

CREATE TABLE Alumno
( 
	CodigoPersona        integer  NOT NULL ,
	DNI                  varchar(20)  NOT NULL ,
	FechaNacimiento      datetime  NULL ,
	Sexo                 integer  NULL 
)
go

ALTER TABLE Alumno
	ADD CONSTRAINT XPKAlumno PRIMARY KEY  CLUSTERED (CodigoPersona ASC)
go

CREATE TABLE AlumnoPeriodo
( 
	CodigoAlumnoPeriodo  integer IDENTITY ( 1,1 ) ,
	CodigoPersona        integer  NOT NULL ,
	CodigoPeriodo        integer  NOT NULL ,	
	CodigoSeccion        integer  NOT NULL ,
	Estado               integer  NULL 
)
go

ALTER TABLE AlumnoPeriodo
	ADD CONSTRAINT XPKAlumnoPeriodo PRIMARY KEY  CLUSTERED (CodigoAlumnoPeriodo ASC)
go

CREATE TABLE CatalogoEstado
( 
	CodigoCatalogo       integer  NOT NULL ,
	ValorCatalgo         integer  NOT NULL ,
	Nombre               varchar(300)  NULL 
)
go

ALTER TABLE CatalogoEstado
	ADD CONSTRAINT XPKCatalogoEstado PRIMARY KEY  CLUSTERED (CodigoCatalogo ASC,ValorCatalgo ASC)
go

CREATE TABLE Evaluacion
( 
	CodigoEvaluacion     integer IDENTITY ( 1,1 ) ,
	Tipo                 integer  NULL ,
	Fecha                datetime  NULL ,
	Hora                 timestamp  NULL ,
	Evaluador            varchar(300)  NULL ,
	Respuesta            integer  NULL ,
	Observacion          varchar(300)  NULL ,
	CodigoUsuario        integer  NULL ,
	CodigoInscripcionDetalle integer  NULL ,
	CodigoAlumnoPeriodo  integer  NULL 
)
go

ALTER TABLE Evaluacion
	ADD CONSTRAINT XPKEvaluacion PRIMARY KEY  CLUSTERED (CodigoEvaluacion ASC)
go

CREATE TABLE Inscripcion
( 
	CodigoInscripcion    integer IDENTITY ( 1,1 ) ,
	DNI                  varchar(20)  NULL ,	
	Tipo                 integer  NOT NULL ,
	Nombre               varchar(300) NOT NULL ,
	ApellidoMaterno      varchar(300) NOT NULL ,
	ApellidoPaterno      varchar(300) NOT NULL ,
	FechaInscripcion     datetime  NOT NULL ,
	Direccion            varchar(20) NOT NULL ,
	CodigoUbigeo         varchar(6)  NOT NULL 
)
go

ALTER TABLE Inscripcion
	ADD CONSTRAINT XPKPreInscripcion PRIMARY KEY  CLUSTERED (CodigoInscripcion ASC)
go

CREATE TABLE InscripcionDetalle
( 
	CodigoInscripcion    integer  NOT NULL ,
	CodigoInscripcionDetalle integer IDENTITY ( 1,1 ) ,
	Nombre               varchar(300)  NOT NULL ,
	ApellidoPaterno      varchar(300)  NOT NULL ,
	ApellidoMaterno      varchar(300)  NOT NULL ,
	FechaNacimiento      datetime  NOT NULL ,
	Sexo                 integer  NOT NULL ,
	CodigoSeccion        integer  NOT NULL 
)
go

ALTER TABLE InscripcionDetalle
	ADD CONSTRAINT XPKInscripcionDetalle PRIMARY KEY  CLUSTERED (CodigoInscripcionDetalle ASC)
go

CREATE TABLE Padre
( 
	CodigoPersona        integer  NOT NULL ,
	DNI                  varchar(20)  NOT NULL ,
	Direccion            varchar(300)  NULL ,
	CodigoUbigeo         varchar(6)  NOT NULL ,
	Tipo                 integer  NULL 
)
go

ALTER TABLE Padre
	ADD CONSTRAINT XPKPadre PRIMARY KEY  CLUSTERED (CodigoPersona ASC)
go

CREATE TABLE Perfil
( 
	CodigoPerfil         integer IDENTITY ( 1,1 ) ,
	Nombre               varchar(300)  NOT NULL 
)
go

ALTER TABLE Perfil
	ADD CONSTRAINT XPKPerfil PRIMARY KEY  CLUSTERED (CodigoPerfil ASC)
go

CREATE TABLE Periodo
( 
	CodigoPeriodo        integer IDENTITY ( 1,1 ) ,
	Anio                 integer  NOT NULL 
)
go

ALTER TABLE Periodo
	ADD CONSTRAINT XPKPeriodo PRIMARY KEY  CLUSTERED (CodigoPeriodo ASC)
go

CREATE TABLE Persona
( 
	CodigoPersona        integer IDENTITY ( 1,1 ) ,
	Nombre               varchar(300)  NOT NULL ,
	ApellidoPaterno      varchar(300)  NOT NULL ,
	Correo               varchar(300)  NULL ,
	ApellidoMaterno      varchar(300)  NULL 
)
go

ALTER TABLE Persona
	ADD CONSTRAINT XPKPersona PRIMARY KEY  CLUSTERED (CodigoPersona ASC)
go

CREATE TABLE Personal
( 
	CodigoPersona        integer  NOT NULL ,
	Cargo                varchar(300)  NULL 	
)
go

ALTER TABLE Personal
	ADD CONSTRAINT XPKPersonal PRIMARY KEY  CLUSTERED (CodigoPersona ASC)
go

CREATE TABLE Seccion
( 
	CodigoSeccion        integer IDENTITY ( 1,1 ) ,
	Nombre               varchar(300)  NOT NULL ,
	Educacion            integer  NOT NULL 
)
go

ALTER TABLE Seccion
	ADD CONSTRAINT XPKSeccion PRIMARY KEY  CLUSTERED (CodigoSeccion ASC)
go

CREATE TABLE Ubigeo
( 
	CodigoUbigeo         varchar(6)  NOT NULL ,
	Nombre               varchar(300)  NOT NULL 
)
go

ALTER TABLE Ubigeo
	ADD CONSTRAINT XPKUbigeo PRIMARY KEY  CLUSTERED (CodigoUbigeo ASC)
go

CREATE TABLE Usuario
( 
	CodigoUsuario        integer IDENTITY ( 1,1 ) ,
	Nombre               varchar(20)  NOT NULL ,
	Contrasenia          varchar(20)  NOT NULL ,
	CodigoPersona        integer  NOT NULL 
)
go

ALTER TABLE Usuario
	ADD CONSTRAINT XPKUsuario PRIMARY KEY  CLUSTERED (CodigoUsuario ASC)
go

CREATE TABLE UsuarioPerfil
( 
	CodigoUsuario        integer  NOT NULL ,
	CodigoPerfil         integer  NOT NULL 
)
go

ALTER TABLE UsuarioPerfil
	ADD CONSTRAINT XPKUsuarioPerfil PRIMARY KEY  CLUSTERED (CodigoUsuario ASC,CodigoPerfil ASC)
go

ALTER TABLE Alumno
	ADD CONSTRAINT R_2 FOREIGN KEY (CodigoPersona) REFERENCES Persona(CodigoPersona)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE AlumnoPeriodo
	ADD CONSTRAINT R_11 FOREIGN KEY (CodigoPersona) REFERENCES Alumno(CodigoPersona)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE AlumnoPeriodo
	ADD CONSTRAINT R_12 FOREIGN KEY (CodigoPeriodo) REFERENCES Periodo(CodigoPeriodo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE AlumnoPeriodo
	ADD CONSTRAINT R_14 FOREIGN KEY (CodigoSeccion) REFERENCES Seccion(CodigoSeccion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Evaluacion
	ADD CONSTRAINT R_16 FOREIGN KEY (CodigoUsuario) REFERENCES Usuario(CodigoUsuario)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Evaluacion
	ADD CONSTRAINT R_17 FOREIGN KEY (CodigoInscripcionDetalle) REFERENCES InscripcionDetalle(CodigoInscripcionDetalle)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Evaluacion
	ADD CONSTRAINT R_18 FOREIGN KEY (CodigoAlumnoPeriodo) REFERENCES AlumnoPeriodo(CodigoAlumnoPeriodo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Inscripcion
	ADD CONSTRAINT R_9 FOREIGN KEY (CodigoUbigeo) REFERENCES Ubigeo(CodigoUbigeo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE InscripcionDetalle
	ADD CONSTRAINT R_8 FOREIGN KEY (CodigoInscripcion) REFERENCES Inscripcion(CodigoInscripcion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE InscripcionDetalle
	ADD CONSTRAINT R_15 FOREIGN KEY (CodigoSeccion) REFERENCES Seccion(CodigoSeccion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Padre
	ADD CONSTRAINT R_1 FOREIGN KEY (CodigoPersona) REFERENCES Persona(CodigoPersona)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Padre
	ADD CONSTRAINT R_7 FOREIGN KEY (CodigoUbigeo) REFERENCES Ubigeo(CodigoUbigeo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Personal
	ADD CONSTRAINT R_3 FOREIGN KEY (CodigoPersona) REFERENCES Persona(CodigoPersona)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Usuario
	ADD CONSTRAINT R_4 FOREIGN KEY (CodigoPersona) REFERENCES Persona(CodigoPersona)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE UsuarioPerfil
	ADD CONSTRAINT R_5 FOREIGN KEY (CodigoUsuario) REFERENCES Usuario(CodigoUsuario)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE UsuarioPerfil
	ADD CONSTRAINT R_6 FOREIGN KEY (CodigoPerfil) REFERENCES Perfil(CodigoPerfil)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go
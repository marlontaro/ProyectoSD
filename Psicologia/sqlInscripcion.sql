
USE UPC2014


create table INSCRIPCION
(
  CodigoInscripcion integer not null,
  DNI  VARCHAR(20) not null,
  Tipo    integer,
  Nombre VARCHAR(300),
  ApellidoPaterno VARCHAR(300),
  ApellidoMaterno VARCHAR(300),
  FechaInscripcion datetime,
  Direccion VARCHAR(20),
  CodigoUbigeo VARCHAR(6)
)

Insert into INSCRIPCION values ('1', '12345678', '1', 'JUAN', 'PEREZ', 'PEREZ', GetDate(), 'AV. LA PAZ 555', '010101')





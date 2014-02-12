if exists (select 1 from sys.procedures where name = 'spAlumnosIns')
drop proc spAlumnosIns
go

create proc spAlumnosIns
(
	@pMatricula varchar(10),
	@pApPaterno varchar(30),
	@pApMaterno varchar(255),
	@pNombre varchar(30),
	@pSexo varchar(1),
	@pCalle varchar(50),
	@pColonia varchar(50),
	@pCP int,
	@ClaPais int,
	@pClaEstado int,
	@pClaCiudad int,
	@pEmpresa varchar (50),
	@pTelefono1 varchar (20),
	@pTelefono2 varchar(20),
	@pEmail varchar(30),
	@pIngreso smalldatetime,
	@pVigencia smalldatetime,
	@pEstatus int,
	@pClaCampus int,
	@pClaNivel int,
	@pClaLeccion int,
	@pSuscriptor varchar(100),
	@pClaAtendio int,
	@pContrato varchar(50),
	@pEspecial TinyInt,
	@pObservaciones varchar(200),
	@pFoto image,
	@pFechaNacimiento smalldatetime,
	@pTelefono3 varchar(20)
	
)
as 
begin

 insert into Alumnos (Matricula, ApPaterno, ApMaterno, Nombre, Sexo, Calle, Colonia, CP, ClaPais, 
  ClaEstado, ClaCiudad, Empresa, Telefono1, Telefono2,Email, Ingreso, Vigencia, Estatus, ClaCampus,
  ClaNivel, ClaLeccion, Suscriptor, ClaAtendio, Contrato, Especial, Observaciones, Foto, FechaNacimiento, Telefono3  ) 
 values(@pMatricula, @pApPaterno, @pApMaterno, @pNombre, @pSexo, @pCalle, @pColonia, @pCP,
 @ClaPais, @pClaEstado, @pClaCiudad, @pEmpresa, @pTelefono1, @pTelefono2, @pEmail, @pIngreso, @pVigencia, 
 @pEstatus, @pClaCampus, @pClaNivel, @pClaLeccion, @pSuscriptor, @pClaAtendio, @pContrato, @pEspecial, @pObservaciones, @pFoto, @pFechaNacimiento, @pTelefono3 )
 
end
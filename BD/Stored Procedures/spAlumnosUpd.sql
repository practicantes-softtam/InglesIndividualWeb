if exists (select 1 from sys.procedures where name = 'spAlumonsUpd')
drop proc spAlumnosUpd
go

create proc spAlumnosUpd
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

	update Alumnos
	set	ApPaterno = @pApPaterno, 
		ApMaterno = @pApMaterno, 
		Nombre = @pNombre, 
		Sexo = @pSexo, 
		Calle = @pCalle, 
		Colonia = @pColonia, 
		CP = @pCP, 
		ClaPais = @ClaPais, 
		ClaEstado = @pClaEstado, 
		ClaCiudad = @pClaCiudad, 
		Empresa = @pEmpresa, 
		Telefono1 = @pTelefono1, 
		Telefono2 = @pTelefono2,
		Email = @pEmail, 
		Ingreso = @pIngreso, 
		Vigencia = @pVigencia, 
		Estatus = @pEstatus, 
		ClaCampus = @pClaCampus,
		ClaNivel = @pClaNivel, 
		ClaLeccion = @pClaLeccion, 
		Suscriptor = @pSuscriptor, 
		ClaAtendio =@pClaAtendio, 
		Contrato = @pContrato, 
		Especial =@pEspecial, 
		Observaciones =@pObservaciones, 
		Foto =@pFoto, 
		FechaNacimiento = @pFechaNacimiento, 
		Telefono3 =@pTelefono3
		
	where Matricula = @pMatricula

end

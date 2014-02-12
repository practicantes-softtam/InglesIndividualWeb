if exists (select 1 from sys.procedures where name = 'spEmpleadosUpd')
drop proc spEmpleadosUpd
go

create proc spEmpleadosUpd
(
	@pClaEmpleado int,
	@pApPaterno varchar(30),
	@pApMaterno varchar(30),
	@pNombre varchar(30),
	@pSexo varchar(1),
	@pClaCampus int,
	@pClaDepartamento int,
	@pClaPuesto int,
	@pCalle varchar(50),
	@pColonia varchar(50),
	@pCP int,
	@pClaPais int,
	@pClaEstado int,
	@pClaCiudad int,
	@pTelefono1 varchar(20),
	@pTelefono2 varchar(20),
	@pEmail varchar(30),
	@pEsDocente tinyInt,
	@pNombreCorto varchar(30),
	@pBaja tinyInt,
	@pFoto image,
	@pObservaciones varchar(200)
	
)
as
begin

	update Empleados
	set	ApPaterno = @pApPaterno,
	ApMaterno = @pApMaterno,
	Nombre = @pNombre,
	Sexo = @pSexo,
	ClaDepartamento = @pClaDepartamento,
	ClaPuesto = @pClaPuesto,
	Calle = @pCalle,
	Colonia = @pColonia,
	CP = @pCP,
	ClaPais = @pClaPais,
	ClaEstado = @pClaEstado,
	ClaCiudad = @pClaCiudad,
	Telefono1 = @pTelefono1,
	Telefono2 = @pTelefono2,
	Email = @pEmail,
	EsDocente = @pEsDocente,
	NombreCorto = @pNombreCorto,
	Baja = @pBaja,
	Foto = @pFoto,
	Observaciones = @pObservaciones

		
	where ClaEmpleado = @pClaEmpleado
	AND ClaCampus = @pClaCampus

end

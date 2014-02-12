if exists (select 1 from sys.procedures where name = 'spEmpleadosIns')
drop proc spEmpleadosIns
go

create proc spEmpleadosIns
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

 insert into Empleados(ClaEmpleado, ApPaterno, ApMaterno, Nombre, Sexo, ClaCampus, ClaDepartamento, ClaPuesto, 
 Calle, Colonia, CP, ClaPais, ClaEstado, ClaCiudad, Telefono1, Telefono2, Email, EsDocente, NombreCorto, Baja, Foto, Observaciones ) 
 values(@pClaEmpleado, @pApPaterno, @pApMaterno, @pNombre, @pSexo, @pClaCampus, @pClaDepartamento, @pClaPuesto,
 @pCalle, @pColonia, @pCP, @pClaPais, @pClaEstado, @pClaCiudad, @pTelefono1, @pTelefono2, @pEmail, @pEsDocente, @pNombreCorto, @pBaja, @pFoto, @pObservaciones)
 
end
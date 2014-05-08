if exists (select * from sys.procedures where name = 'spEmpleadosSel')
begin
	drop proc spEmpleadosSel
end

go

CREATE proc spEmpleadosSel
(
	@pClaEmpleado		int,
	@pClaCampus int,
	@pClaDepartamento int,
	@pClaPuesto int,
	@pClaPais int,
	@pClaEstado int,
	@pClaCiudad int
	

)
as
begin

	select	ClaEmpleado, ApPaterno, ApMaterno, Nombre, Sexo, ClaCampus, ClaDepartamento, ClaPuesto, 
 Calle, Colonia, CP, ClaPais, ClaEstado, ClaCiudad, Telefono1, Telefono2, Email, EsDocente, NombreCorto, Baja, Foto, Observaciones 
 
	from	Empleados
	where	
	((ClaEmpleado =	@pClaEmpleado) or @pClaEmpleado = -1) and
	((ClaCampus = @pClaCampus) or @pClaCampus = -1) and
	((ClaDepartamento = @pClaDepartamento) or @pClaDepartamento = -1) and
	((ClaPuesto = @pClaPuesto) or @pClaPuesto = -1) and
	((ClaPais = @pClaPais) or @pClaPais = -1) and
	((ClaEstado = @pClaEstado) or @pClaEstado = -1) and
	((ClaCiudad = @pClaCiudad) or @pClaCiudad = -1)
end
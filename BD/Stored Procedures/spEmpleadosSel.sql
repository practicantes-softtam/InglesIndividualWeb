if exists (select * from sys.procedures where name = 'spEmpleadosSel')
begin
	drop proc spEmpleadosSel
end

go

CREATE proc spEmpleadosSel
(
	@pClaEmpleado		int

)
as
begin

	select	ClaEmpleado, ApPaterno, ApMaterno, Nombre, Sexo, ClaCampus, ClaDepartamento, ClaPuesto, 
 Calle, Colonia, CP, ClaPais, ClaEstado, ClaCiudad, Telefono1, Telefono2, Email, EsDocente, NombreCorto, Baja, Foto, Observaciones 
 
	from	Empleados
	where	ClaEmpleado =	@pClaEmpleado
end
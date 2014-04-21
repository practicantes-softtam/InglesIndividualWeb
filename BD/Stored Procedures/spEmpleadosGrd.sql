if exists (select 1 from sys.procedures where name = 'spEmpleadosGrd')
drop proc spEmpleadosGrd
go

CREATE proc spEmpleadosGrd
(
	@pNombre varchar(30),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNombre is not null begin
		select @pNombre = '%' + @pNombre + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by Nombre asc), 
		ClaEmpleado,
ApPaterno,ApMaterno,Nombre,Sexo,ClaCampus,ClaDepartamento,ClaPuesto,Calle,Colonia,
CP,ClaPais,ClaEstado,ClaCiudad,Telefono1,Telefono2,Email,EsDocente,NombreCorto,
Baja,Foto,Observaciones
	into #tabla
	from Empleados
	where @pNombre like @pNombre
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
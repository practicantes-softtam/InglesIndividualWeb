if exists (select 1 from sys.procedures where name = 'spAlumnosGrd')
drop proc spAlumnosGrd
go
CREATE proc spAlumnosGrd
(
	@pNombre    varchar(30),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin
	if @pNombre is not null begin
		select @pNombre = '%' + @pNombre + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by Matricula asc), 
		Matricula,ApPaterno,ApMaterno,Nombre,Sexo,Calle,Colonia,CP,ClaPais,ClaEstado,ClaCiudad,Empresa,
Telefono1,Telefono2,Email,Ingreso,Vigencia,Estatus,ClaCampus,ClaNivel,ClaLeccion,Suscriptor,ClaAtendio,
Contrato,Especial,Observaciones,Foto,FechaNacimiento,Telefono3
	into #tabla
	from Alumnos
	where Nombre like @pNombre
	exec spGridPaginado @pTamanioPagina,@pNumPagina,@pOrdenarPor
	
	end
	--select * from #tabla
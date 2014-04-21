if exists (select 1 from sys.procedures where name = 'spAsistenciaGrd')
drop proc spAsistenciaGrd
go

CREATE proc spAsistenciaGrd
(
	@pFechaHora DateTime,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pFechaHora is not null begin
		select @pFechaHora = '%' + @pFechaHora + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by FechaHora asc), 
		 IdRegistro,ClaCampus,Matricula,ClaEmpleado,TipoPersona,FechaHora,Mensaje,IdCita,RegistroValido
	into #tabla
	from Asistencia
	where FechaHora like @pFechaHora
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

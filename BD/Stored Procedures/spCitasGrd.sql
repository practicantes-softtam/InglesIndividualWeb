if exists (select 1 from sys.procedures where name = 'spCitasGrd')
drop proc spCitasGrd
go

CREATE proc spCitasGrd
(
	@pFechaHora datetime,
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
		IdCita,ClaCampus,Matricula,ClaProfesor,FechaHora,TipoClase,Estatus,
ClaNivel,ClaLeccion,FechaHoraOriginal,Observaciones,ModManual,FechaHoraAsistencia,Aprobo
	into #tabla
	from Citas
	where @pFechaHora like @pFechaHora
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
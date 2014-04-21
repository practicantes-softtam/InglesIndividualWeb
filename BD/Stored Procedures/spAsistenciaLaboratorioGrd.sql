if exists (select 1 from sys.procedures where name = 'spAsistenciaLaboratorioGrd')
drop proc spAsistenciaLaboratorioGrd
go

CREATE proc spAsistenciaLaboratorioGrd
(
	@pFecha DateTime,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pFecha is not null begin
		select @pFecha = '%' + @pFecha + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by Fecha asc), 
		IdAsistenciaLaboratorio,ClaCampus,Matricula,Fecha
	into #tabla
	from AsistenciaLaboratorio
	where Fecha like @pFecha
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
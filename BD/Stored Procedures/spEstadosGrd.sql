if exists (select 1 from sys.procedures where name = 'spEstadosGrd')
drop proc spEstadosGrd
go

CREATE proc spEstadosGrd
(
	@pClaPais		int,
	@pNomEstado		varchar(30),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor	varchar(100)
)
as
begin

	if @pNomEstado is not null begin
		select @pNomEstado = '%' + @pNomEstado + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaEstado asc), 
			ClaEstado, NomEstado, ClaPais
	into #tabla
	from Estados
	where NomEstado like @pNomEstado
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


if exists (select 1 from sys.procedures where name = 'spEncuestasGrd')
drop proc spEncuestasGrd
go

CREATE proc spEncuestasGrd
(
	@pNomEncuesta varchar(50),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNomEncuesta is not null begin
		select @pNomEncuesta = '%' + @pNomEncuesta + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaEncuesta asc), 
	ClaEncuesta,NomEncuesta
	into #tabla
	from Encuestas
	where @pNomEncuesta like @pNomEncuesta
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
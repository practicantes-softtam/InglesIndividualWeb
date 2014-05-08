if exists (select 1 from sys.procedures where name = 'spDepartamentosGrd')
drop proc spDepartamentosGrd
go

CREATE proc spDepartamentosGrd
(
	@pNomDepartamento varchar(30),
	@pClaDepartamento int,
	@pClaCampus int,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNomDepartamento is not null begin
		select @pNomDepartamento = '%' + @pNomDepartamento + '%'
	end	

	
	select	RowNumber = ROW_NUMBER() over (order by ClaDepartamento asc), 
		ClaDepartamento,
		ClaCampus,
		NomDepartamento	
		 
	

	into #tabla

	from Departamentos 
	where ClaDepartamento like @pClaDepartamento
	and (ClaCampus = @pClaCampus or @pClaCampus = 0)
	and NomDepartamento like '%' + @pNomDepartamento + '%'
	
	

	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
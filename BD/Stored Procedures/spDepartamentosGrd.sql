if exists(select 1 from sys.procedures where name = 'spDepartamentosGrd')
drop proc spDepartamentosGrd
go

create proc spDepartamentosGrd
(
	@pTamanioPagina		int,
	@pNumPagina			int,
	@pOrdenarPor		varchar(100),
	@pClaDepartamento	int,
	@pClaCampus			int,
	@pNomDepartamento	varchar (30)
)
as
begin

		if @pClaDepartamento is not null begin
		select @pClaDepartamento = '%' + @pClaDepartamento + '%'
	end	
	
	select	RowNumber = ROW_NUMBER() over (order by d.ClaDepartamento asc), 
		d.ClaDepartamento,
		d.ClaCampus,
		d.NomDepartamento	
		 
	
	into #tabla
	from Departamentos d
	where ClaDepartamento like @pClaDepartamento
	and (ClaCampus = @pClaCampus or @pClaCampus = 0)
	and d.NomDepartamento like '%' + @pNomDepartamento + '%'
	
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


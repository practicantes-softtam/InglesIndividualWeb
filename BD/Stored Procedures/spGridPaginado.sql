if exists (select 1 from sys.procedures where name = 'spGridPaginado')
drop proc spGridPaginado
go

CREATE proc spGridPaginado
(
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor	varchar(100)
)
as
begin

	select @pNumPagina = @pNumPagina + 1
	
	declare @pagIni			int,
			@pagFin			int,
			@totalPaginas	int,
			@totalRegistros	int

		
	select @totalRegistros = count(*)
	from #tabla
	
	if(@pTamanioPagina <> -1)
	begin
		select @totalPaginas = @totalRegistros / @pTamanioPagina
	end
	
	if @totalPaginas * @pTamanioPagina < @totalRegistros begin
	
		select @totalPaginas = @totalPaginas + 1
		
	end

	if @pNumPagina <= @totalPaginas begin

		select @pagFin = @pNumPagina * @pTamanioPagina
	
	end
	else begin
	
		select @pagFin = @totalPaginas
		
	end	
	
	select @pagIni = (@pagFin - @pTamanioPagina) + 1
	select @pTamanioPagina = @pTamanioPagina
	if(@pTamanioPagina <> -1)
	begin
		declare @sql varchar(1000)
		
		select @sql = 'select *, TotalRegistros = ' + cast(@totalRegistros as varchar) + ' from #tabla ' + 
			'where RowNumber between ' + cast(@pagIni as varchar) + ' and ' + cast(@pagFin as varchar)
		
		if isnull(@pOrdenarPor, '') <> '' begin
			select @sql = @sql + ' order by ' + @pOrdenarPor
		end
		exec (@sql)
	end
	else
	begin
		select * from #tabla
	end
	
	
end


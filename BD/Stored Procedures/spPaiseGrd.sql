if exists (select 1 from sys.procedures where name = 'spPaisesGrd')
drop proc spPaisesGrd
go
CREATE proc spPaisesGrd
(
	@pNomPais    varchar(50),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin
	if @pNomPais is not null begin
		select @pNomPais = '%' + @pNomPais + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaPais asc), 
		ClaPais, NomPais
	into #tabla
	from Paises
	where NomPais like @pNomPais
	exec spGridPaginado @pTamanioPagina,@pNumPagina,@pOrdenarPor
	
	end

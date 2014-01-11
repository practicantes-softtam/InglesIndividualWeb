if exists (select 1 from sys.procedures where name = 'spPuestosGrd')
drop proc spPuestosGrd
go

CREATE proc spPuestosGrd
(
	@pNomPuesto		varchar(30),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNomPuesto is not null begin
		select @pNomPuesto = '%' + @pNomPuesto + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaPuesto asc), 
			ClaPuesto, NomPuesto
	into #tabla
	from Puestos 
	where NomPuesto like @pNomPuesto
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


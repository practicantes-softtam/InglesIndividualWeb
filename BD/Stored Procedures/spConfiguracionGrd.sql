if exists (select 1 from sys.procedures where name = 'spConfiguracionGrd')
drop proc spConfiguracionGrd
go

CREATE proc spConfiguracionGrd
(
	@pNomConfig varchar(255),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNomConfig is not null begin
		select @pNomConfig = '%' + @pNomConfig + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by NomConfig asc), 
		ClaCategoria,ClaConfig,NomConfig,ValorEntero,ValorCadena,Editable
	into #tabla
	from Configuracion
	where @pNomConfig like @pNomConfig
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
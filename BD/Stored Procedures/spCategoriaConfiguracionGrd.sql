if exists (select 1 from sys.procedures where name = 'spCategoriaConfiguracionGrd')
drop proc spAsistenciaLaboratorioGrd
go

CREATE proc spCategoriaConfiguracionGrd
(
	@pNomCategoria varchar(100),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNomCategoria is not null begin
		select @pNomCategoria = '%' + @pNomCategoria + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by NomCategoria asc), 
		ClaCategoria,NomCategoria
	into #tabla
	from CategoriaConfiguracion
	where @pNomCategoria like @pNomCategoria
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
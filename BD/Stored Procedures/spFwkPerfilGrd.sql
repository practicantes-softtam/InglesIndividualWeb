if exists (select 1 from sys.procedures where name = 'spFwkPerfilesGrd')
drop proc spFwkPerfilesGrd
go

CREATE proc spFwkPerfilesGrd
(
	@pNomPerfil varchar (50),
	@pClaAplicacion	int,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNomPerfil is not null begin
		select @pNomPerfil = '%' + @pNomPerfil+ '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaPerfil asc), 
		 ClaPerfil, NomPerfil, ClaAplicacion
	into #tabla
	from FwkPerfiles
	where NomPerfil like @pNomPerfil
	and (ClaAplicacion=@pClaAplicacion or @pClaAplicacion=0)
		
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

select*from #tabla
if exists (select 1 from sys.procedures where name = 'spFwkUsuarioAplicacionGrd')
drop proc spFwkUsuarioAplicacionGrd
go

CREATE proc spFwkUsuarioAplicacionGrd
(
	@pNomCiudad varchar (50),
	@pClaEstado	int,
	@pClaPais int,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	--if @pNomCiudad is not null begin
		--select @pNomCiudad = '%' + @pNomCiudad + '%'
	--end	

	select	RowNumber = ROW_NUMBER() over (order by ClaAplicacion asc), 
		 ClaAplicacion, IdUsuario
	into #tabla1
	from FwkUsuarioAplicacion
	--where  like 
	
	
	--exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

select*from #tabla1
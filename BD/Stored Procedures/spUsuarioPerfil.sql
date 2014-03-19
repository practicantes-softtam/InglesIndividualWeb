if exists (select 1 from sys.procedures where name = 'spFwkUsuarioPerfilFrd')
drop proc spFwkUsuarioPerfilGrd
go

CREATE proc spFwkUsuarioPerfilGrd
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

	select	RowNumber = ROW_NUMBER() over (order by IdUsuario asc), 
		  IdUsuario,ClaAplicacion
	into #tabla1
	from FwkUsuarioPerfil
	--where  like 
	
	
	--exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
select * from #tabla1
if exists (select 1 from sys.procedures where name = 'spFwkPermisosPerfilGrd')
drop proc spFwkPermisosPerfilGrd
go

CREATE proc spFwkPermisosPerfilGrd
(
	@pPermitir tinyint,
	@pClaAplicacion	int,
	@pClaModulo int,
	@pClaObjeto int,
	@pClaAccion char(5),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pPermitir is not null begin
		select @pPermitir = '%' + @pPermitir + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaPerfil asc), 
		 ClaPerfil, Permitir, ClaAplicacion,ClaModulo,ClaObjeto,ClaAccion
	into #tabla1
	from FwkPermisosPerfil
	where Permitir like @pPermitir
	and (ClaAplicacion=@pClaAplicacion or @pClaAplicacion=0)
	and (ClaModulo=@pClaModulo or @pClaModulo=0)
	and (ClaObjeto=@pClaObjeto or @pClaObjeto=0)
	and (ClaAccion=@pClaAccion or @pClaAccion=0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


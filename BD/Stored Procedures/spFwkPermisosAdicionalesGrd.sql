if exists (select 1 from sys.procedures where name = 'spFwkPermisosAdicionalesGrd')
drop proc spFwkPermisosAdicionalesGrd
go

CREATE proc spFwkPermisosAdicionalesGrd
(
	@pPermitir tinyint,
	@pClaAplicacion	int,
	@pClaModulo int,
	@pClaObjeto int,
	@pClaAccion int,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pPermitir is not null begin
		select @pPermitir = '%' + @pPermitir + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by IdUsuario asc), 
		 IdUsuario, Permitir, ClaAplicacion,ClaModulo,ClaObjeto,ClaAccion
	into #tabla1
	from FwkPermisosAdicionales
	where Permitir like @pPermitir
	and (ClaAplicacion=@pClaAplicacion or @pClaAplicacion=0)
	and (ClaModulo=@pClaModulo or @pClaModulo=0)
	and (ClaObjeto=@pClaObjeto or @pClaObjeto=0)
	and (ClaAccion=@pClaAccion or @pClaAccion=0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

select*from #tabla1
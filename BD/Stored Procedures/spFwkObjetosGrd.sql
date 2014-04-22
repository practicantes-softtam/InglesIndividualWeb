if exists (select 1 from sys.procedures where name = 'spFwkObjetosGrd')
drop proc spFwkObjetosGrd
go

CREATE proc spFwkObjetosGrd
(
	@pClaveObjeto varchar (10),
	@pClaAplicacion	int,
	@pClamodulo int,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pClaveObjeto is not null begin
		select @pClaveObjeto = '%' + @pClaveObjeto + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaObjeto asc), 
		 ClaObjeto,NomObjeto,Url,ClaveObjeto, ClaAplicacion, ClaModulo
	into #tabla
	from FwkObjetos
	where ClaveObjeto like @pClaveObjeto
	and (ClaAplicacion=@pClaAplicacion or @pClaAplicacion=0)
	and (ClaModulo=@pClamodulo or @pClamodulo=0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

select*from #tabla
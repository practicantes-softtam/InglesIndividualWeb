if exists (select 1 from sys.procedures where name = 'spFwkObjetosGrd')
drop proc spFwkObjetosGrd
go

CREATE proc spFwkObjetosGrd
(
	@pNomObjeto varchar (100),
	@pClaAplicacion	int,
	@pClamodulo int,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNomObjeto is not null begin
		select @pNomObjeto = '%' + @pNomObjeto + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaObjeto asc), 
		 ClaObjeto,NomObjeto,Url,ClaveObjeto, ClaAplicacion, ClaModulo
	into #tabla2
	from FwkObjetos
	where NomObjeto like @pNomObjeto 
	and (ClaAplicacion=@pClaAplicacion or @pClaAplicacion=0)
	and (ClaModulo=@pClamodulo or @pClamodulo=0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

select*from #tabla2
if exists (select 1 from sys.procedures where name = 'spFwkModulosGrd')
drop proc spFwkModulosGrd
go

CREATE proc spFwkModulosGrd
(
	@pNomModulo	varchar(30),
	@pClaAplicacion int,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNomModulo is not null begin
		select @pNomModulo = '%' + @pNomModulo + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaModulo asc), 
			 ClaModulo,NomModulo,ClaModuloPadre,ClaAplicacion
	into #tabla
	from FwkModulos
	where NomModulo like @pNomModulo
	and (ClaAplicacion=@pClaAplicacion or @pClaAplicacion=0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

select * from #tabla


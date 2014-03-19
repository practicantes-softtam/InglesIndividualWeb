if exists (select 1 from sys.procedures where name = 'spFwkAccionesGrd')
drop proc spFwkAccionesGrd
go

CREATE proc spFwkAccionesGrd
(
	@pDescripcion	varchar(50),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pDescripcion is not null begin
		select @pDescripcion = '%' + @pDescripcion + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaAccion asc), 
			ClaAccion, Descripcion
	into #tabla
	from FwkAcciones
	
	where Descripcion like @pDescripcion
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
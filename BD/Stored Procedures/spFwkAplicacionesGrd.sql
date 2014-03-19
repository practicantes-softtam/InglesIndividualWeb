if exists (select 1 from sys.procedures where name = 'spFwkAplicacionesGrd')
drop proc spFwkAplicacionesGrd

go

CREATE proc spFwkAplicacionesGrd
(
	@pNomAplicacion		varchar(50),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNomAplicacion is not null begin
		select @pNomAplicacion = '%' + @pNomAplicacion + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaAplicacion asc), 
			ClaAplicacion, NomAplicacion
	into #tabla
	from FwkAplicaciones
	where NomAplicacion like @pNomAplicacion
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

select * from FwkAplicaciones
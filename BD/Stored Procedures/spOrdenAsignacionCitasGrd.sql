if exists(select 1 from sys.procedures where name = 'spOrdenAsignacionCitasGrd')
drop proc spOrdenAsignacionCitasGrd
go

create proc spOrdenAsignacionCitasGrd
(
	@pTamanioPagina		int,
	@pNumPagina			int,
	@pOrdenarPor		varchar(100),
	@pClaCampus			int,
	@pClaProfesor		int,
	@pOrden				int
)
as
begin

		if @pClaCampus is not null begin
		select @pClaCampus = '%' + @pClaCampus + '%'
	end	
	
	select	RowNumber = ROW_NUMBER() over (order by ClaCampus asc), 
		ClaCampus,
		ClaProfesor,
		Orden	
		 
	
	into #tabla
	from OrdenAsignacionCitas 
	where ClaCampus like @pClaCampus
	and (ClaProfesor = @pClaProfesor or @pClaProfesor = 0)
	and (Orden = @pOrden or @pOrden = 0)
	
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


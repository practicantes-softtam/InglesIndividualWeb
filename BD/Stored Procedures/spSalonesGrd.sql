if exists(select 1 from sys.procedures where name = 'spSalonesGrd')
drop proc spSalonesGrd
go


create proc spSalonesGrd
(
	@pTamanioPagina		int,
	@pNumPagina			int,
	@pOrdenarPor		varchar(100),
	@pIdSalon			int out,
	@pClaCampus			int,
	@pNomSalon			varchar,
	@pCapacidad			int
)

as
begin

		if @pIdSalon is not null begin
		select @pIdSalon = '%' + @pIdSalon + '%'
	end	
	
	select	RowNumber = ROW_NUMBER() over (order by ClaCampus asc), 
		IdSalon, ClaCampus, NomSalon, Capacidad
		 
	
	into #tabla
	from Salones 
	where NomSalon like @pNomSalon
	
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


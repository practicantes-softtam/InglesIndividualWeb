if exists(select 1 from sys.procedures where name = 'spLeccionesGrd')
drop proc spLeccionesGrd
go

create proc spLeccionesGrd
(
	@pTamanioPagina		int,
	@pNumPagina			int,
	@pOrdenarPor		varchar(100),
	@pClaLeccion		int,
	@pClaNivel			int,
	@pNomLeccion		varchar (30),
	@pEsReview			int
)
as
begin

		if @pNomLeccion is not null begin
		select @pNomLeccion = '%' + @pNomLeccion + '%'
	end	
	
	select	RowNumber = ROW_NUMBER() over (order by ClaLeccion asc), 
		ClaLeccion, NomLeccion, ClaNivel, EsReview
		
	into #tabla
	from Lecciones 
	where NomLeccion like @pNomLeccion
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


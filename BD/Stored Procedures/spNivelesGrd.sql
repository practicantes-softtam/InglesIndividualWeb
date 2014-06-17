if exists(select 1 from sys.procedures where name = 'spNivelesGrd')
drop proc spNivelesGrd
go

create proc spNivelesGrd
(
	@pTamanioPagina		int,
	@pNumPagina			int,
	@pOrdenarPor		varchar(100),
	@pClaNivel			int,
	@pNomNivel			varchar (30),
	@pClubConversacion	int
)
as
begin
	
	if @pNomNivel is not null begin
	select @pNomNivel = '%' + @pNomNivel + '%'
	end	
	
	select	RowNumber = ROW_NUMBER() over (order by ClaNivel asc), 
		ClaNivel,
		NomNivel,
		ClubConversacion	
		 
	
	into #tabla
	from Niveles 
	where NomNivel like @pNomNivel
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


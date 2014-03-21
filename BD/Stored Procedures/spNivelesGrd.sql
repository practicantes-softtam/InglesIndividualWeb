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

		if @pClaNivel is not null begin
		select @pClaNivel = '%' + @pClaNivel + '%'
	end	
	
	select	RowNumber = ROW_NUMBER() over (order by n.ClaNivel asc), 
		n.ClaNivel,
		n.NomNivel,
		n.ClubConversacion	
		 
	
	into #tabla
	from Niveles n
	where ClaNivel like @pClaNivel
	and (NomNivel = @pNomNivel or @pNomNivel = 0)
	and (ClubConversacion = @pClubConversacion or @pClubConversacion = 0)
	and n.NomNivel like '%' + @pNomNivel + '%'
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


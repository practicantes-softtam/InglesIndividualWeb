if exists (select 1 from sys.procedures where name = 'spNivelesIns')
drop proc spNivelesIns
go

create proc spNivelesIns
(

	@pClaNivel int out,
	@pNomNivel varchar (30),
	@pClubConversacion int
	
)
as
begin

	select @pClaNivel = ISNULL (MAX (ClaNivel), 0) +1
	from Niveles
	
	insert into Niveles (ClaNivel,		NomNivel)
	values				(@pClaNivel,	@pNomNivel)
	
end

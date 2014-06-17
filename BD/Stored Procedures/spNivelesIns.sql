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
	insert into Niveles (NomNivel)
	values (@pNomNivel)
	
	select @pClaNivel = @@IDENTITY
end

if exists (select 1 from sys.procedures where name = 'spNivelesUpd')
drop proc spNivelesUpd 
go

create proc spNivelesUpd
(
	@pClaNivel int out,
	@pNomNivel varchar (30),
	@pClubConversacion int
)
as
begin

	update Niveles
	set NomNivel = @pNomNivel, @pClaNivel = @pClubConversacion
	
	where ClaNivel = @pClaNivel
end

if exists (select 1 from sys.procedures where name = 'spHorarioClubConversacionDel')
drop proc spHorarioClubConversacionDel
go

create proc spHorarioClubConversacionDel
(
	@pClaCampus int
	
)
as
begin

	delete HorarioClubConversacion 
	where ClaCampus = @pClaCampus

end

exec spHorarioClubConversacionDel 10
	select * from HorarioClubConversacion
if exists (select 1 from sys.procedures where name = 'spHorarioClubConversacionUpd')
drop proc spHorarioClubConversacionUpd 
go

create proc spHorarioClubConversacionUpd
(
	@pClaCampus int out,
	@pClaEmpleado int,
	@pClaHorario int,
	@pClaDia int,
	@pHoras int
)
as
begin

	update HorarioClubConversacion
	set ClaCampus = @pClaCampus,  ClaEmpleado = @pClaEmpleado, ClaHorario = @pClaHorario, ClaDia = @pClaDia, Horas = @pHoras
	
	where ClaCampus = @pClaCampus
end

exec spHorarioClubConversacionUpd 10, 'HorarioClubConversacion 10', 1,1
	select * from HorarioClubConversacion
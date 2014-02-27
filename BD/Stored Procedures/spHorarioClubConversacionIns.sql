if exists (select 1 from sys.procedures where name = 'spHorarioClubConversacionIns')
drop proc spHorarioClubConversacionIns
go

create proc spHorarioClubConversacionIns
(

	@pClaCampus int out,
	@pClaEmpleado int,
	@pClaHorario int,
	@pClaDia int,
	@pHoras int
	
)
as
begin
	select @pClaCampus = isnull  (MAX (ClaCampus), 0)+ 1 
	from HorarioClubConversacion

	insert into HorarioClubConversacion	(ClaCampus,		ClaEmpleado,	ClaHorario,		ClaDia, Horas) 
	values					(@pClaCampus,	@pClaEmpleado,	@pClaHorario, @pClaDia, @pHoras)

end

if exists (select * from sys.procedures where name = 'HorarioClubConversacion')
begin
	drop proc spHorarioClubConversacionSel
end

go

CREATE proc spHorarioClubConversacionSel
(
	@pClaCampus		int,
	@pClaEmpleado	int,
	@pClaHorario	int,
	@pClaDia	int

)
as 
begin

select	ClaCampus,
		ClaEmpleado,
		ClaHorario,
		ClaDia
from	HorarioClubConversacion
where	ClaCampus = @pClaCampus

end




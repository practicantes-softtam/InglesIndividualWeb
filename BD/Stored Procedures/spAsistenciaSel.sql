if exists (select * from sys.procedures where name = 'spAsistenciaSel')
begin
	drop proc spAmpliacionesSel
end

go

CREATE proc spAsistenciaSel
(
	@pIdRegistro		int,
	@pClaCampus int,
	@pClaEmpleado int,
	@pIdCita int
)
as
begin

	select	IdRegistro, ClaCampus, Matricula, ClaEmpleado, TipoPersona, FechaHora, Mensaje, IdCita, RegistroValido
 
	from	Asistencia
	where	
	((IdRegistro	=	@pIdRegistro) or @pIdRegistro = -1) and
	((ClaCampus = @pClaCampus) or @pClaCampus = -1) and
	((ClaEmpleado = @pClaEmpleado) or @pClaEmpleado = -1) and
	((IdCita = @pIdCita) or @pIdCita = .1)
end
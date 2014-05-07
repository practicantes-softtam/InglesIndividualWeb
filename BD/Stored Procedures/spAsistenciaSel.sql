if exists (select * from sys.procedures where name = 'spAsistenciaSel')
begin
	drop proc spAmpliacionesSel
end

go

CREATE proc spAsistenciaSel
(
	@pIdRegistro		int
)
as
begin

	select	IdRegistro, ClaCampus, Matricula, ClaEmpleado, TipoPersona, FechaHora, Mensaje, IdCita, RegistroValido
 
	from	Asistencia
	where	IdRegistro	=	@pIdRegistro
end
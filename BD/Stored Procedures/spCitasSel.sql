if exists (select * from sys.procedures where name = 'spCitasSel')
begin
	drop proc spCitasSel
end

go

CREATE proc spCitasSel
(
	@pIdCita		int,
	@pClaCampus int,
	@pClaProfesor int,
	@pClaNivel int,
	@pClaLeccion int
)
as
begin

	select	IdCita, ClaCampus, Matricula, ClaProfesor, FechaHora, TipoClase, Estatus, ClaNivel, ClaLeccion, FechaHoraOriginal, Observaciones, ModManual, FechaHoraAsistencia, Aprobo
 
	from	Citas
	where	
	((IdCita	=	@pIdCita) or @pIdCita = -1) and
	((ClaCampus = @pClaCampus) or @pClaCampus = -1) and
	((ClaProfesor = @pClaProfesor) or @pClaProfesor = -1) and
	((ClaNivel = @pClaNivel) or @pClaNivel = -1)and
	((ClaLeccion = @pClaLeccion) or @pClaLeccion = -1)
end
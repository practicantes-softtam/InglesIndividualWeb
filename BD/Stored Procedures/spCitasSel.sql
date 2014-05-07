if exists (select * from sys.procedures where name = 'spCitasSel')
begin
	drop proc spCitasSel
end

go

CREATE proc spCitasSel
(
	@pIdCita		int
)
as
begin

	select	IdCita, ClaCampus, Matricula, ClaProfesor, FechaHora, TipoClase, Estatus, ClaNivel, ClaLeccion, FechaHoraOriginal, Observaciones, ModManual, FechaHoraAsistencia, Aprobo
 
	from	Citas
	where	IdCita	=	@pIdCita
end
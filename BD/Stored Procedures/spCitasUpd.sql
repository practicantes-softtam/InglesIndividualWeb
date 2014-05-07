if exists (select 1 from sys.procedures where name = 'spCitasUpd')
drop proc spCitasUpd
go

create proc spCitasUpd
(
	@pIdCita int out,
	@pClaCampus int,
	@pMatricula varchar(10),
	@pClaProfesor int,
	@pFechaHora smalldatetime,
	@pTipoClase tinyInt,
	@pEstatus tinyInt,
	@pClaNivel Int,
	@pClaLeccion int,
	@pFechaHoraOriginal smalldatetime,
	@pObservaciones varchar(256),
	@pModManual tinyInt,
	@pFechaHoraAsstencia smalldatetime,
	@pAprobo tinyInt
)
as
begin

	update Citas
	set	ClaCampus = @pClaCampus,
	Matricula = @pMatricula,
	ClaProfesor = @pClaProfesor,
	FechaHora = @pFechaHora,
	TipoClase = @pTipoClase,
	Estatus = @pEstatus,
	ClaNivel = @pClaNivel,
	ClaLeccion = @pClaLeccion,
	FechaHoraOriginal = @pFechaHoraOriginal,
	Observaciones = @pObservaciones,
	ModManual = @pModManual,
	FechaHoraAsistencia = @pFechaHoraAsstencia,
	Aprobo = @pAprobo

		
	where IdCita = @pIdCita

end

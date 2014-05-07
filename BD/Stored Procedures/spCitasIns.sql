if exists (select 1 from sys.procedures where name = 'spCitasIns')
drop proc spCitasIns
go

create proc spCitasIns
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

 insert into Citas(ClaCampus, Matricula, ClaProfesor, FechaHora, TipoClase, Estatus, ClaNivel, ClaLeccion, FechaHoraOriginal, Observaciones, ModManual, FechaHoraAsistencia, Aprobo ) 
 values(@pClaCampus, @pMatricula, @pClaProfesor, @pFechaHora, @pTipoClase, @pEstatus, @pClaNivel, @pClaLeccion, @pFechaHoraOriginal, @pObservaciones, @pModManual, @pFechaHoraAsstencia, @pAprobo)
  select @pIdCita = @@IDENTITY
end
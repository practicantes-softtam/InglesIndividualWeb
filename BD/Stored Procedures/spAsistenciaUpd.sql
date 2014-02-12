if exists (select 1 from sys.procedures where name = 'spAsistenciaUpd')
drop proc spAsistenciaUpd
go

create proc spAsistenciaUpd
(
	@pIdRegistro int,
	@pClaCampus int,
	@pMatricula varchar(10),
	@pClaEmpleado int,
	@pTipoPersona int,
	@pFechaHora smalldatetime,
	@pMensaje varchar(1000),
	@pIdCita int,
	@pRegistroValido int
)
as
begin

	update Asistencia
	set	ClaCampus = @pClaCampus,
	Matricula = @pMatricula,
	ClaEmpleado = @pClaEmpleado,
	TipoPersona = @pTipoPersona,
	FechaHora = @pFechaHora,
	Mensaje = @pMensaje,
	IdCita = @pIdCita,
	RegistroValido = @pRegistroValido
		
	where IdRegistro = @pIdRegistro

end

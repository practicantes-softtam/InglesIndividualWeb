if exists (select 1 from sys.procedures where name = 'spAsistenciaIns')
drop proc spAsistenciaIns
go

create proc spAsistenciaIns
(
	@pIdRegistro int out,
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

 insert into Asistencia (ClaCampus, Matricula, ClaEmpleado, TipoPersona, FechaHora, Mensaje, IdCita, RegistroValido ) 
 values(@pClaCampus, @pMatricula, @pClaEmpleado, @pTipoPersona, @pFechaHora, @pMensaje, @pIdCita,@pRegistroValido)
  select @pIdRegistro = @@IDENTITY
end
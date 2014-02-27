if exists (select 1 from sys.procedures where name = 'spHuellasPersonasDel')
drop proc spHuellasPersonasDel
go

create proc spHuellasPersonasDel
(
	@pIdRegistro int out,
	@pClaCampus int,
	@pMatricula varchar (10),
	@pTipoPersona int,
	@pHuella image
)
as
begin

	delete HuellasPersonas
	where IdRegistro = @pIdRegistro


end


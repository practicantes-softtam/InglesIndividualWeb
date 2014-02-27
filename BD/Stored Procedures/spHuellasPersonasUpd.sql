if exists (select 1 from sys.procedures where name = 'spHuellasPersonasUpd')
drop proc spHuellasPersonasUpd 
go

create proc spHuellasPersonasUpd
(
@pIdRegistro int out,
	@pClaCampus int,
	@pMatricula varchar (10),
	@pTipoPersona int,
	@pHuella image
	
)
as
begin

	update HuellasPersonas
	set ClaCampus = @pClaCampus,  Matricula= @pMatricula, TipoPersona=@pTipoPersona, Huella=@pHuella
	
	where ClaCampus = @pClaCampus
end


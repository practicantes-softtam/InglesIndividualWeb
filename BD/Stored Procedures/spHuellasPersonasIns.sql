if exists (select 1 from sys.procedures where name = 'spHuellasPersonasIns')
drop proc spHuellasPersonasIns 
go

create proc spHuellasPersonasIns
(
	@pIdRegistro int out,
	@pClaCampus int,
	@pMatricula varchar (10),
	@pTipoPersona int,
	@pHuella image
	
)
as
begin


	insert into HuellasPersonas (ClaCampus, Matricula, TipoPersona, Huella)
	values (@pClaCampus, @pMatricula, @pTipoPersona, @pHuella)
	
	select @pIdRegistro = @@IDENTITY
end


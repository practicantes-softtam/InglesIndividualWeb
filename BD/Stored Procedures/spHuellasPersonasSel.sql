if exists (select * from sys.procedures where name = 'spHuellasPersonasSel')
begin
	drop proc spHuellasPersonasSel
end

go

CREATE proc spHuellasPersonasSel
(
	@pIdRegistro		int
)
as
begin

	select	IdRegistro,
			ClaCampus,
			Matricula,
			ClaEmpleado,	
			TipoPersona,
			Huella
	
	from	HuellasPersonas 
	where	IdRegistro	=	@pIdRegistro
end



if exists (select * from sys.procedures where name = 'spFwkUsuariosSel')
begin
	drop proc spFwkUsuariosSel
end

go

CREATE proc spFwkUsuariosSel
(
	@pIdUsuario		varchar (50)
)
as
begin
	
	select	IdUsuario,
			NomUsuario
	from	FwkUsuarios
	where	IdUsuario = @pIdUsuario
end
	
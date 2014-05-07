if exists (select * from sys.procedures where name = 'spFwkUsuariosSistemaSeguridadSel')
begin
	drop proc spFwkUsuariosSistemaSeguridadSel
end

go

CREATE proc spFwkUsuariosSistemaSeguridadSel
(
	@pIdRegistro		int
)
as
begin
	
	select	IdRegistro,
			IdUsuario
	from	FwkUsuariosSistemaSeguridad
	where	IdRegistro = @pIdRegistro
end
	
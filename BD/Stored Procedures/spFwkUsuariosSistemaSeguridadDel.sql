if exists (select 1 from sys.procedures where name = 'spFwkUsuariosSistemaSeguridadDel')
drop proc spFwkUsuariosSistemaSeguridadDel
go

create proc spFwkUsuariosSistemaSeguridadDel
(
	@pIdRegistro int

)
as
begin

	delete FwkUsuariosSistemaSeguridad
	where IdRegistro = @pIdRegistro


end

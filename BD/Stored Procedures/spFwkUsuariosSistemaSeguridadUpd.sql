if exists (select 1 from sys.procedures where name = 'spFwkUsuariosSistemaSeguridadUpd')
drop proc spFwkUsuariosSistemaSeguridadUpd 
go

create proc spFwkUsuariosSistemaSeguridadUpd
(
	@pIdRegistro int out,
	@pIdeUsuario varchar (50) 

)
as
begin

	update FwkUsuariosSistemaSeguridad
	set IdUsuario = @pIdeUsuario
	
	where IdRegistro =@pIdRegistro
end
 

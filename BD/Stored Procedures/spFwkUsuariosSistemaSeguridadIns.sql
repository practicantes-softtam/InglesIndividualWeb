if exists (select 1 from sys.procedures where name = 'spFwkUsuariosSistemaSeguridadIns')
drop proc spFwkUsuariosSistemaSeguridadIns
go

create proc spFwkUsuariosSistemaSeguridadIns
(
	@pIdRegistro int out,
	@pIdUsuario varchar (50)
)

as
begin

	insert into FwkUsuariosSistemaSeguridad (IdRegistro, IdUsuario)
	values (@pIdRegistro, @pIdUsuario)
	
	select @pIdRegistro = @@IDENTITY
end


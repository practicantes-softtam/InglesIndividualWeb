
if exists (select 1 from sys.procedures where name = 'spFwkUsuarioAplicacionUpd')
drop proc spFwkUsuarioAplicacionUpd
go

create proc spFwkUsuarioAplicacionUpd
(
	@pClaAplicacion int,
	@IdUsuario varchar(50)
)
as
begin

	update FwkUsuarioAplicacion
    set ClaAplicacion= @pClaAplicacion,
    IdUsuario=@IdUsuario
  
	--where ClaAplicacion = @pClaAplicacion
	--AND IdUsuario = @IdUsuario

end
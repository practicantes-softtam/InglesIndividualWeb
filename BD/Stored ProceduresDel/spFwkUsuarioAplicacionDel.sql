
if exists (select 1 from sys.procedures where name = 'spFwkUsuarioAplicacionDel')
drop proc spFwkUsuarioAplicacionDel
go

create proc spFwkUsuarioAplicacionDel
(
@pClaAplicacion int,
@IdUsuario varchar(50)
)
as
begin

	delete FwkUsuarioAplicacion

	where ClaAplicacion = @pClaAplicacion
	AND IdUsuario = @IdUsuario

end
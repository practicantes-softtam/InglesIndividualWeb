
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
select fwka.NomAplicacion, fwku.NomUsuario
from FwkUsuarioAplicacion fwkua
inner join FwkAplicaciones fwka on  fwkua.ClaAplicacion=  fwka.ClaAplicacion
inner join  FwkUsuarios fwku on fwku.IdUsuario = fwku.IdUsuario
update FwkUsuarioAplicacion
    set ClaAplicacion= @pClaAplicacion,
    IdUsuario=@IdUsuario
  where ClaAplicacion = @pClaAplicacion
	AND IdUsuario = @IdUsuario

end
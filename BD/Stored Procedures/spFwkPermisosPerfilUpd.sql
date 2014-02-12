if exists (select 1 from sys.procedures where name = 'spFwkPermisosPerfilUpd')
drop proc spFwkPermisosPerfilUpd
go

create proc spFwkPermisosPerfilUpd
(
@pClaAplicacion int ,
@pClaPerfil int,
@pClaModulo int,
@pClaObjeto int,
@pClaAccion int,
@pPermitir tinyint
)
as
begin

	update  FwkPermisosPerfil
	set Permitir=@pPermitir
	where ClaAplicacion = @pClaAplicacion
	AND ClaPerfil= @pClaPerfil
	AND ClaModulo=@pClaModulo
	AND ClaObjeto =@pClaObjeto
	AND  ClaAccion=@pClaAccion

end

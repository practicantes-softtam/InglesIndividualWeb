if exists (select 1 from sys.procedures where name = 'spFwkPermisosPerfilDel')
drop proc spFwkPermisosPerfilDel
go

create proc spFwkPermisosPerfilDel

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

	delete FwkPermisosPerfil
	
	where ClaAplicacion = @pClaAplicacion
	AND ClaPerfil= @pClaPerfil
	AND ClaModulo=@pClaModulo
	AND ClaObjeto =@pClaObjeto
	AND  ClaAccion=@pClaAccion

end
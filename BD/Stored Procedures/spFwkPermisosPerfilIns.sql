if exists (select 1 from sys.procedures where name = 'spFwkPermisosPerfilIns')
drop proc spFwkPermisosPerfilIns
go

create proc spFwkPermisosPerfilIns
(
	@pClaAplicacion int ,
	@pClaPerfil int,
	@pClaModulo int,
	@pClaObjeto int,
	@pClaAccion char(5),
	@pPermitir tinyint
)
as
begin

	 insert into FwkPermisosPerfil ( ClaAplicacion, ClaPerfil,ClaModulo,ClaObjeto,ClaAccion,Permitir) 
 values(@pClaAplicacion, @pClaPerfil, @pClaModulo,@pClaObjeto,@pClaAccion,@pPermitir )
	

end
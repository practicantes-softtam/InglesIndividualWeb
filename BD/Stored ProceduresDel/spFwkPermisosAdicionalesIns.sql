if exists (select 1 from sys.procedures where name = 'spFwkPermisosAdicionalesIns')
drop proc spFwkPermisosAdicionalesIns
go

create proc spFwkPermisosAdicionalesIns
(
	@pIdUsuario varchar (50),
	@ClaAplicacion int,
	@pClaModulo int,
	@pClaObjeto int,
	@pClaAccion char (4),
	@pPermitir tinyint
)
as 
begin

 insert into FwkPermisosAdicionales  (IdUsuario, ClaAplicacion, ClaModulo, ClaObjeto, ClaAccion,Permitir) 
 values(@pIdUsuario,@ClaAplicacion, @pClaModulo,@pClaObjeto,@pClaAccion,@pPermitir )
 
end
if exists (select 1 from sys.procedures where name = 'spFwkPermisosAdicionalesDel')
drop proc spFwkPermisosAdicionalesDel
go

create proc spFwkPermisosAdicionalesDel
(
	
	@pIdUsuario varchar (50),
	@ClaAplicacion int,
	@pClaModulo int,
	@pClaObjeto int,
	@pClaAccion char (4)
	
)
as
begin

	delete FwkPermisosAdicionales 
	where IdUsuario=@pIdUsuario
	AND ClaAplicacion=@ClaAplicacion
	AND ClaModulo=@pClaModulo
	AND ClaObjeto=@pClaObjeto
	AND ClaAccion=@pClaAccion


end
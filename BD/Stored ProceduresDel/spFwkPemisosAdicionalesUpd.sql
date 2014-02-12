if exists (select 1 from sys.procedures where name = 'spFwkPermisosAdicionalesUpd')

drop proc spFwkPermisosAdicionalesUpd
go

create proc spFwkPermisosAdicionalesUpd
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

	update FwkPermisosAdicionales
	set Permitir=@pPermitir
	where IdUsuario=@pIdUsuario
	AND ClaAplicacion=@ClaAplicacion
	AND ClaModulo=@pClaModulo
	AND ClaObjeto=@pClaObjeto
	AND ClaAccion=@pClaAccion
	end
	
	select * from FwkPermisosAdicionales
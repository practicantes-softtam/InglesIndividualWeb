if exists (select 1 from sys.procedures where name = 'spFwkObjetosDel')
drop proc spFwkObjetosDel
go

create proc spFwkObjetosDel
(
	@pClaAplicacion int,
	@pClaModulo int,
	@pClaObjeto int
)
as
begin

	delete FwkObjetos
	where ClaAplicacion=@pClaAplicacion
	AND ClaModulo= @pClaModulo
	AND ClaObjeto=@pClaObjeto
end

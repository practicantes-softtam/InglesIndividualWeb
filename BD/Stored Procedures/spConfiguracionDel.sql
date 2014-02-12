if exists (select 1 from sys.procedures where name = 'spConfiguracionDel')
drop proc spConfiguracionDel
go

create proc spConfiguracionDel
(
	@pClaConfig int,
	@pClaCategoria int
)
as
begin

	delete Configuracion 
	where ClaConfig = @pClaConfig 
	AND ClaCategoria = @pClaCategoria


end
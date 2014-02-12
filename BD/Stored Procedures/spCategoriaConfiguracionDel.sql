if exists (select 1 from sys.procedures where name = 'spCategoriaConfiguracionDel')
drop proc spCategoriaConfiguracionDel
go

create proc spCategoriaConfiguracionDel
(
	@pClaCategoria int
)
as
begin

	delete CategoriaConfiguracion
	where ClaCategoria = @pClaCategoria



end
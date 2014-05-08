if exists (select * from sys.procedures where name = 'spCategoriaConfiguracionSel')
begin
	drop proc spCategoriaConfiguracionSel
end

go

CREATE proc spCategoriaConfiguracionSel
(
	@pClaCategoria		int
)
as
begin

	select	ClaCategoria, NomCategoria
 
	from	CategoriaConfiguracion
	where	
	((ClaCategoria	=	@pClaCategoria) or @pClaCategoria = -1)
end
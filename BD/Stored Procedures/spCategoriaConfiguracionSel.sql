if exists (select * from sys.procedures where name = 'spCategoriaConfiguracionSel')
begin
	drop proc spAsistenciaLaboratorioSel
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
	where	ClaCategoria	=	@pClaCategoria
end
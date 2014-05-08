if exists (select * from sys.procedures where name = 'spConfiguracionSel')
begin
	drop proc spConfiguracionSel
end

go

CREATE proc spConfiguracionSel
(
	@pClaCategoria		int,
	@pClaConfig	int
)
as
begin

	select	ClaCategoria, ClaConfig, NomConfig, ValorEntero, ValorCadena, Editable
 
	from	Configuracion
	where	
	((ClaCategoria	=	@pClaCategoria) or @pClaCategoria = -1) and
	((ClaConfig = @pClaConfig) or @pClaConfig = -1)
end
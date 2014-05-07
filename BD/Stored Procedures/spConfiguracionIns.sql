if exists (select 1 from sys.procedures where name = 'spConfiguracionIns')
drop proc spConfiguracionIns
go

create proc spConfiguracionIns 
(
	@pClaCategoria int out,
	@pClaConfig int out,
	@pNomConfig varchar(255),
	@pValorEntero int,
	@pValorCadena varchar(100),
	@pEditable tinyint
)
as 
begin

 insert into Configuracion (ClaCategoria, ClaConfig, NomConfig, ValorEntero, ValorCadena, Editable) 
 values(@pClaCategoria, @pClaConfig, @pNomConfig, @pValorEntero, @pValorCadena, @pEditable  )
 
end

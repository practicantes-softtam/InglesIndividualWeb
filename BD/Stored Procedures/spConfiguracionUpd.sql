if exists (select 1 from sys.procedures where name = 'spConfiguracionUpd')
drop proc spEstadosIns
go

create proc spConfiguracionUpd
(
	@pClaCategoria int,
	@pClaConfig int,
	@pNomConfig varchar(255),
	@pValorEntero int,
	@pValorCadena varchar(100),
	@pEditable tinyint
)
as
begin

	update Configuracion
	set NomConfig =@pNomConfig
	where ClaCategoria = @pClaCategoria AND ClaConfig = @pClaConfig

end

--Configuracion
if exists (select 1 from sys.procedures where name = 'spCategoriaConfiguracionIns')
drop proc spCategoriaConfiguracionIns
go

create proc spCategoriaConfiguracionIns
(
	@pClaCategoria int,
	@pNomCategoria varchar(100)

)
as 
begin

 insert into CategoriaConfiguracion(ClaCategoria, NomCategoria ) 
 values(@pClaCategoria, @pNomCategoria)
 
end
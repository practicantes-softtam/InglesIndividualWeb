if exists (select 1 from sys.procedures where name = 'spCategoriaConfiguracionUpd')
drop proc spCategoriaConfiguracionUpd
go

create proc spCategoriaConfiguracionUpd
(
	@pClaCategoria int,
	@pNomCategoria varchar(100)
)
as
begin

	update CategoriaConfiguracion
	set	NomCategoria = @pNomCategoria

		
	where ClaCategoria = @pClaCategoria

end

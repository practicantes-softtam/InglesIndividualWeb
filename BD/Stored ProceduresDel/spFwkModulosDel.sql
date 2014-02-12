if exists (select 1 from sys.procedures where name = 'spFwkModulosDel')
drop proc spFwkModulosDel
go

create proc spFwkModulosDel
(
	@pClaApliacion int,
	@pClaModulo int
)
as
begin

	delete FwkModulos
	where ClaAplicacion = @pClaApliacion
	AND ClaModulo = @pClaModulo


end
if exists (select 1 from sys.procedures where name = 'spFwkModulosUpd')
drop proc spFwkModulosUpd
go

create proc spFwkModulosUpd
(
	@pClaAplicacion int out,
	@pClaModulo int  ,
	@pNomModulo  varchar(50),
	@pClaModuloPadre int
)
as
begin

	update FwkModulos
	set NomModulo=@pNomModulo,
	ClaModuloPadre=@pClaModuloPadre
	where ClaAplicacion = @pClaAplicacion 
	AND ClaModulo= @pClaModulo
end

select * from FwkModulos
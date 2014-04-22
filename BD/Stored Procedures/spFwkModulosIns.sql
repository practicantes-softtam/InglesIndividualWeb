if exists (select 1 from sys.procedures where name = 'spFwkModulosIns')
drop proc spFwkModulosIns
go

create proc spFwkModulosIns
(
	@pClaAplicacion int out,
	@pClaModulo int out ,
	@pNomModulo  varchar(50),
	@pClaModuloPadre int
)
as 
begin

 insert into FwkModulos (ClaAplicacion, ClaModulo, NomModulo, ClaModuloPadre) 
 values(@pClaAplicacion, @pClaModulo,@pNomModulo, @pClaModuloPadre)
 end

select * from FwkModulos
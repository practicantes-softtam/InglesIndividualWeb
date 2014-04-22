if exists(select 1 from sys.procedures where name ='spFwkAccionesIns')
drop proc spFwkAccionesIns
go
create proc spFwkAccionesIns
(
	@pClaAccion char (5) out,
	@pDescripcion varchar(50)
)
as 
begin
	select @pClaAccion = ISNULL (Max (ClaAccion),0) +1
	from  FwkAcciones
	insert into FwkAcciones(ClaAccion, Descripcion) 
	values (@pClaAccion, @pDescripcion)
end


select * from FwkAcciones

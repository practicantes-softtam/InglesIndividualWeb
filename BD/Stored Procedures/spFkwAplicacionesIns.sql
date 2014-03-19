if exists(select 1 from sys.procedures where name ='spFwkAplicacionesIns')
drop proc spFwkAplicacionesIns
go
create proc spFwkAplicacionesIns
(
	@pClaAplicacion int out,
	@pNomAplicacion varchar(50)
)
as 
begin
	select @pClaAplicacion= ISNULL (Max (ClaAplicacion),0) +1
	from  FwkAplicaciones
	insert into FwkAplicaciones(ClaAplicacion, NomAplicacion) 
	values (@pClaAplicacion, @pNomAplicacion)
end

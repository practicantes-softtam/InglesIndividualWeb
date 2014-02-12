if exists (select 1 from sys.procedures where name = 'spFwkUsuarioAplicacionIns')
drop proc spFwkUsuarioAplicacionIns
go
create proc spFwkUsuarioAplicacionIns
(
	@pClaAplicacion int,
	@IdUsuario varchar(50)
	)
	
as
begin
	
	
	insert into FwkUsuarioAplicacion(ClaAplicacion, IdUsuario) 
	values (@pClaAplicacion, @IdUsuario)
       
end

select * from FwkAcciones


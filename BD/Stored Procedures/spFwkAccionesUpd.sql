if exists(select 1 from sys.procedures where name = 'spFwkAccionesUpd')
drop proc spFwkAccionesUpd
go
create proc spFwkAccionesUpd
(
	@pClaAccion char(5) out,
	@pDescripcion varchar(50)
	)
	
as
begin
	update FwkAcciones
	set Descripcion= @pDescripcion
		
	where ClaAccion = @pClaAccion
       
end

select * from FwkAcciones

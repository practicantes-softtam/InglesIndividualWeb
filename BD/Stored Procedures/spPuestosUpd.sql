if exists (select 1 from sys.procedures where name = 'spPuestosUpd')
drop proc spPuestosUpd 
go

create proc spPuestosUpd
(
	@pClaPuesto int out,
	@pNomPuesto varchar (30)
)
as
begin

	update Puestos
	set NomPuesto = @pNomPuesto
	
	where ClaPuesto = @pClaPuesto
end


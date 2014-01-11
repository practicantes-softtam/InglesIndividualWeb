if exists (select 1 from sys.procedures where name = 'spPuestosDel')
drop proc spPuestosDel
go

create proc spPuestosDel
(
	@pClaPuesto	int
)
as
begin

	delete Puestos where ClaPuesto = @pClaPuesto
	
end
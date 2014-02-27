if exists (select 1 from sys.procedures where name = 'spPuestosIns')
drop proc spPuestosIns
go

create proc spPuestosIns
(

	@pClaPuesto int out,
	@pNomPuesto varchar (30)
	
	
)
as
begin

	insert into Puestos (NomPuesto)
	values (@pNomPuesto)
	
	select @pClaPuesto = @@IDENTITY
end


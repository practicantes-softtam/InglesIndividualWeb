if exists (select 1 from sys.procedures where name = 'spSalonesIns')
drop proc spSalonesIns
go

create proc spSalonesIns
(

	@pIdSalon int out,
	@pClaCampus int,
	@pNomSalon varchar (20),
	@pCapacidad int
	
)
as
begin

	insert into Salones (ClaCampus, NomSalon, Capacidad)
	values (@pClaCampus, @pNomSalon, @pCapacidad)
	
	select @pIdSalon = @@IDENTITY
end


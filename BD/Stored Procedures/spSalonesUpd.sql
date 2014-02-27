if exists (select 1 from sys.procedures where name = 'spSalonesUpd')
drop proc spSalonesUpd 
go

create proc spSalonesUpd
(
	@pIdSalon int out,
	@pNomSalon varchar (20), 
	@pClaCampus int,
	@pCapacidad int
)
as
begin

	update Salones
	set NomSalon = @pNomSalon,  ClaCampus = @pClaCampus, Capacidad = @pCapacidad
	
	where IdSalon = @pIdSalon
end


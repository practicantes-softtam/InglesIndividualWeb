if exists (select 1 from sys.procedures where name = 'spSalonesUpd')
drop proc spSalonesUpd 
go

create proc spSalonesUpd
(
	@pIdSalon int out,
	@pNomSalon varchar (20), 
	@pClaCampus int,
	@pClaCapacidad int
)
as
begin

	update Salones
	set NomSalon = @pNomSalon,  ClaCampus = @pClaCampus, ClaCapacidad = @pClaCapacidad
	
	where IdSalon = @pIdSalon
end

exec spSalonesUpd 10, 'Salon 10', 1,1
	select * from Salones
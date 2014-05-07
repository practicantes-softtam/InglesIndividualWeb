if exists(select 1 from sys.procedures where name = 'spCampusUpd')
drop proc spCampusUpd
go
create proc spCampusUpd
(
	@pClaCampus int,
	@pNomCampus varchar(50)

)
as
begin

	update Campus
	set NomCampus = @pNomCampus
	
	where ClaCampus = @pClaCampus

end
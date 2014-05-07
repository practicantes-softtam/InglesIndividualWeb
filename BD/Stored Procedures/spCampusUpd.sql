if exists(select 1 from sys.procedures where name = 'spCampusUpd')
drop proc spCampusUpd
go

create proc spCampusUpd
(
	@pClaCampus					int  out,
	@pNomCampus					varchar(50),
	@pCalle						varchar (200),
	@pColonia					varchar (200),
	@pTelefono					varchar (15),
	@pCodigoPostal				int,
	@pClaPais					int,
	@pClaEstado					int,
	@pClaCiudad					int,
	@pDirectorGeneral			varchar (100),
	@pDirectorAdministrativo	varchar (100)

)
as
begin

	update Campus
	set NomCampus = @pNomCampus
	
	where ClaCampus = @pClaCampus
	and ClaCiudad = @pClaCiudad
	and ClaEstado = @pClaEstado
	and ClaPais = @pClaPais

end
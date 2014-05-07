if exists(select 1 from sys.procedures where name = 'spCampusIns')
drop proc spCampusIns
go

create proc spCampusIns
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

	select @pClaCampus = ISNULL (MAX (ClaCampus), 0)+1
	from Campus
	where ClaCiudad = @pClaCiudad
	
	insert into Campus (ClaCampus, NomCampus, Calle, Colonia, CodigoPostal,
	ClaPais, ClaEstado, ClaCiudad, Telefono, DirectorGeneral, DirectorAdministrativo)
	values (@pClaCampus, @pNomCampus, @pCalle, @pColonia, @pTelefono, @pCodigoPostal,
	@pClaPais, @pClaEstado, @pClaCiudad, @pDirectorGeneral, @pDirectorAdministrativo)
	
	--insert into Campus (NomCampus, Calle, Colonia, Telefono)
	--values (@pNomCampus, @pCalle, @pColonia, @pTelefono)
	--select @pClaCampus = @@IDENTITY
end
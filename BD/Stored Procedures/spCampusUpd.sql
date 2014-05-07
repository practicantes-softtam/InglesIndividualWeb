if exists(select 1 from sys.procedures where name = 'spCampusUpd')
drop proc spCampusUpd
go
create proc spCampusUpd
(
	@pClaCampus int,
	@pNomCampus varchar(50),
	@pCalle varchar(200),
	@pColonia varchar(200),
	@pCodigoPostal int,
	@pClaPais int,
	@pClaEstado int,
	@pClaCiudad int,
	@pTelefono varchar(15),
	@pDirectorGeneral varchar(100),
	@pDirectorAdministrativo varchar(100)
)
as
begin
	update Campus
	
	set NomCampus=@pNomCampus,
		Calle = @pCalle, 
		Colonia = @pColonia,
		CodigoPostal = @pCodigoPostal,
		ClaPais = @pClaPais,
		ClaEstado = @pClaEstado,
		ClaCiudad = @pClaCiudad,
		Telefono = @pTelefono,
		DirectorGeneral = @pDirectorGeneral,
		DirectorAdministrativo= @pDirectorAdministrativo
	
	where ClaCampus = @pClaCampus
	and ClaCiudad = @pClaCiudad
	and ClaEstado =@pClaEstado
	and ClaPais = @pClaPais
       
end





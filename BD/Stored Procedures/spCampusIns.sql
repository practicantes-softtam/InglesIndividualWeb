if exists(select 1 from sys.procedures where name = 'spCampusIns')
drop proc spCampusIns
go
create proc spCampusIns
(
	@pClaCampus int  out,
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
	select @pClaCampus = ISNULL (Max (ClaCampus),0) +1
	from Campus
	
	insert into Campus(ClaCampus, NomCampus, Calle, Colonia, CodigoPostal, ClaPais,
		ClaEstado, ClaCiudad, Telefono, DirectorGeneral, DirectorAdministrativo) 
	values(@pClaCampus, @pNomCampus, @pCalle, @pColonia, @pCodigoPostal, @pClaPais,
		@pClaEstado, @pClaCiudad,@pTelefono, @pDirectorGeneral, @pDirectorAdministrativo)
		
end



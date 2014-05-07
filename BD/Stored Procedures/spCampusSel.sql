if exists (select * from sys.procedures where name = 'spCampusSel')
begin
	drop proc spCampusSel
end

go

CREATE proc spCampusSel
(
	@pClaCampus		int
)
as
begin

	select	ClaCampus,
			NomCampus,
			Calle,
			Colonia,
			CodigoPostal,
			ClaPais,
			ClaEstado,
			ClaCiudad,
			Telefono,
			DirectorGeneral,
			DirectorAdministrativo
	from	Campus
	where	ClaCampus	=	@pClaCampus
end



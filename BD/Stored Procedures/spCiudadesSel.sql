if exists (select * from sys.procedures where name = 'spCiudadesSel')
begin
	drop proc spCiudadesSel
end

go

CREATE proc spCiudadesSel
(
	@pClaCiudad		int
)

as
begin

	select	ClaCiudad,
			ClaEstado,
			ClaPais,
			NomCiudad
	from	Ciudades
	where	ClaCiudad = @pClaCiudad
end
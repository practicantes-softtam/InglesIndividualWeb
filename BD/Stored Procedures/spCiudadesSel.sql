if exists (select * from sys.procedures where name = 'spCiudadesSel')
begin
	drop proc spCiudadesSel
end

go

CREATE proc spCiudadesSel
(
	@pClaCiudad		int,
	@pClaEstado		int,
	@pClaPais		int,
	@pNomCiudad		varchar (40)
	
)

as
begin
	select	ClaCiudad, ClaEstado, ClaPais, NomCiudad
	from	Ciudades
	where ((ClaCiudad = @pClaCiudad) or @pClaCiudad = -1)
end
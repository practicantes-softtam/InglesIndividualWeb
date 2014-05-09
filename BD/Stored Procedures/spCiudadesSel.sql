if exists (select * from sys.procedures where name = 'spCiudadesSel')
begin
	drop proc spCiudadesSel
end

go

CREATE proc spCiudadesSel
(
	@pClaCiudad		int,
	@pClaEstado		int,
	@pClaPais		int	
)

as
begin
	select	ClaPais, 
			ClaEstado,
			ClaCiudad,
			NomCiudad
	from	Ciudades
	where	((ClaPais = @pClaPais) or @pClaPais = -1)
	and		((ClaEstado = @pClaEstado) or @pClaEstado = -1)
	and		((ClaCiudad = @pClaCiudad) or @pClaCiudad = -1)
end
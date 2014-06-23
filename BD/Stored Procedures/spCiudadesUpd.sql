if exists (select 1 from sys.procedures where name = 'spCiudadesUpd')
drop proc spCiudadesUpd 
go

create proc spCiudadesUpd
(
	@pClaPais	int,
	@pClaEstado	int,
	@pClaCiudad	int,
	@pNomCiudad	varchar	(50)
)
as
begin

	update Ciudades
	set NomCiudad = @pNomCiudad
	
	where	ClaCiudad = @pClaCiudad
	and		ClaEstado = @pClaEstado
	and		ClaPais	= @pClaPais
end

if exists (select 1 from sys.procedures where name = 'spCiudadesUpd')
drop proc spCiudadesUpd 
go

create proc spCiudadesUpd
(
	@pClaCiudad int out,
	@pNomCiudad varchar (30), 
	@pClaEstado int,
	@pClaPais int
)
as
begin

	update Ciudades
	set NomCiudad = @pNomCiudad
	where ClaCiudad = @pClaCiudad
	and ClaEstado = @pClaEstado 
	and ClaPais = @pClaPais
end
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
	set NomCiudad = @pNomCiudad,  ClaEstado = @pClaEstado, ClaPais = @pClaPais
	
	where ClaCiudad = @pClaCiudad
end

exec spCiudadesUpd 10, 'Ciudad 10', 1,1
	select * from Ciudades
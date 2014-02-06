if exists (select 1 from sys.procedures where name = 'spCiudadesDel')
drop proc spCiudadesDel
go

create proc spCiudadesDel
(
	@pClaCiudad int,
	@pClaEstado	int,
	@pClaPais	int
)
as
begin

	delete Ciudades 
	where ClaCiudad = @pClaCiudad
	and ClaPais = @pClaPais
	and ClaEstado = @pClaEstado

end
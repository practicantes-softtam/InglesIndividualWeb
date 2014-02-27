if exists (select 1 from sys.procedures where name = 'spCiudadesDel')
drop proc spCiudadesDel
go

create proc spCiudadesDel
(
	@pClaCiudad int
	
)
as
begin

	delete Ciudades 
	where ClaCiudad = @pClaCiudad

end


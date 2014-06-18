if exists (select 1 from sys.procedures where name = 'spCiudadesIns')
drop proc spCiudadesIns 
go

create proc spCiudadesIns
(
	@pClaCiudad int out,
	@pNomCiudad varchar (30),
	@pClaEstado int,
	@pClaPais int
)
as
begin
	select @pClaCiudad = isnull  (MAX (ClaCiudad), 0)+ 1 
	from Ciudades
	where ClaEstado = @pClaEstado

	insert into Ciudades	(ClaCiudad,		NomCiudad,	ClaEstado,		ClaPais) 
	values					(@pClaCiudad,	@pNomCiudad,	@pClaEstado, @pClaPais)

end


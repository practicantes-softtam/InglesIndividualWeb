if exists (select 1 from sys.procedures where name = 'spCiudadesIns')
drop proc spCiudadesIns 
go

create proc spCiudadesIns
(
	@pClaPais int,
	@pClaEstado int,
	@pClaCiudad int out,
	@pNomCiudad varchar (50)
)
as
begin
	select	@pClaCiudad = isnull  (MAX (ClaCiudad), 0)+ 1 
	from	Ciudades
	where	ClaEstado = @pClaEstado
	and		ClaPais =	@pClaPais

	insert into Ciudades	(ClaCiudad,		NomCiudad,		ClaEstado,		ClaPais) 
	values					(@pClaCiudad,	@pNomCiudad,	@pClaEstado,	@pClaPais)

end


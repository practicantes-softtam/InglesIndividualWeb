if exists(select 1 from sys.procedures where name = 'spCampusGrd')
drop proc spCampusGrd
go

create proc spCampusGrd
(
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor	varchar(100),
	@pNomCampus		varchar(50),
	@pClaPais		int,
	@pClaEstado		int,
	@pClaCiudad		int
)
as
begin

	select	RowNumber = ROW_NUMBER() over (order by c.ClaCampus),
			c.ClaCampus,
			c.NomCampus,
			c.Calle,
			c.Colonia,
			c.CodigoPostal,
			p.NomPais,
			e.NomEstado,
			cd.NomCiudad,
			c.Telefono,
			c.DirectorGeneral
	into #tabla
	from Campus c
	inner join Paises p on c.ClaPais = p.ClaPais
	inner join Estados e on p.ClaPais = e.ClaPais and c.ClaEstado = e.ClaEstado
	inner join Ciudades cd on c.ClaCiudad = cd.ClaCiudad 
		and e.ClaEstado = cd.ClaEstado and p.ClaPais = cd.ClaPais
	where (c.ClaPais = @pClaPais or @pClaPais = 0)
	and (c.ClaEstado = @pClaEstado or @pClaEstado = 0)
	and (c.ClaCiudad = @pClaCiudad or @pClaCiudad = 0)
	and c.NomCampus like '%' + @pNomCampus + '%'

	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor
end


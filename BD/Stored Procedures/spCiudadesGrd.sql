if exists (select 1 from sys.procedures where name = 'spCiudadesGrd')
drop proc spCiudadesGrd
go

CREATE proc spCiudadesGrd
(

	@pNomCiudad varchar (50),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pNomCiudad is not null begin
		select @pNomCiudad = '%' + @pNomCiudad + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaCiudad asc), 
		 ClaCiudad, NomCiudad, ClaEstado, ClaPais
	into #tabla
	from Ciudades
	where NomCiudad like @pNomCiudad 
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


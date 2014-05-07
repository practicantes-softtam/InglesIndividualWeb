if exists(select 1 from sys.procedures where name = 'spCampusGrd')
drop proc spCampusGrd
go

create proc spCampusGrd
(
	@pNomCampus varchar(50),
	@pCalle varchar (200),
	@pColonia varchar (200),
	@pTelefono varchar (15),
	@pClaPais int,
	@pClaEstado int,
	@pClaCiudad int,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor	varchar(100)
	
)
as
begin

	if @pNomCampus is not null begin
	select @pNomCampus = '%' + @pNomCampus + '%'
	end
	
	select RowNumber = ROW_NUMBER() over (order by ClaCampus asc),
	ClaCampus, NomCampus, ClaCiudad, ClaEstado, ClaPais, Calle, Colonia, Telefono
	into #tabla
	from Campus
	where NomCampus like @pNomCampus
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end



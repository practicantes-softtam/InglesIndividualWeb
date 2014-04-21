if exists (select 1 from sys.procedures where name = 'spExtensionesCursoGrd')
drop proc spExtensionesCursoGrd
go

CREATE proc spExtensionesCursoGrd
(
	@pMatricula varchar(10),
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pMatricula is not null begin
		select @pMatricula = '%' + @pMatricula + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by Matricula asc), 
	IdRegistro,ClaCampus,Matricula,FechaIni,FechaFin,Comentarios,Estatus,ClaNivel,
ClaLeccion,TipoRegistro
	into #tabla
	from ExtensionesCurso
	where @pMatricula like @pMatricula
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
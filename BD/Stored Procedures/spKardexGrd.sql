if exists(select 1 from sys.procedures where name = 'spKardexGrd')
drop proc spKardexGrd
go

create proc spKardexGrd
(
	@pTamanioPagina		int,
	@pNumPagina			int,
	@pOrdenarPor		varchar(100),
	@pIdCalificacion	int,
	@pMatricula			varchar (10),
	@pClaCampus			int,
	@pClaNivel			int,
	@pClaLeccion		int,
	@pClaProfesor		int,
	@pCalificacion		decimal,
	@pTipoClase			tinyint,
	@pFecha				smalldatetime,
	@pClaCalificacion	int,
	@pIdCita			int
	
)
as
begin

		if @pMatricula is not null begin
		select @pMatricula = '%' + @pMatricula + '%'
	end	
	
	select	RowNumber = ROW_NUMBER() over (order by Matricula asc), 
		IdCalificacion, Matricula, ClaCampus, ClaNivel,	ClaLeccion, ClaProfesor,
		Calificacion, TipoClase, Fecha, ClaCalificacion, IdCita
		 
	
	into #tabla
	from Kardex 
	where Matricula like @pMatricula
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


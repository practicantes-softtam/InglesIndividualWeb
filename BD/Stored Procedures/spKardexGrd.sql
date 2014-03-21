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

		if @pIdCalificacion is not null begin
		select @pIdCalificacion = '%' + @pIdCalificacion + '%'
	end	
	
	select	RowNumber = ROW_NUMBER() over (order by k.IdCalificacion asc), 
		k.IdCalificacion,
		k.Matricula,
		k.ClaCampus,
		k.ClaNivel,
		k.ClaLeccion,
		k.ClaProfesor,
		k.Calificacion,
		k.TipoClase,
		k.Fecha,
		k.ClaCalificacion,
		k.IdCita
		 
	
	into #tabla
	from Kardex k
	where IdCalificacion like @pIdCalificacion
	and (Matricula = @pMatricula or @pMatricula = 0)
	and (ClaCampus = @pClaCampus or @pClaCampus = 0)
	and (ClaNivel = @pClaNivel or @pClaNivel = 0)
	and (ClaLeccion = @pClaLeccion or @pClaLeccion = 0)
	and (ClaProfesor = @pClaProfesor or @pClaProfesor = 0)
	and (Calificacion = @pCalificacion or @pCalificacion = 0)
	and (TipoClase = @pTipoClase or @pTipoClase = 0)
	and (ClaCalificacion = @pClaCalificacion or @pClaCalificacion = 0)
	and (IdCita = @pIdCita or @pIdCita = 0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end


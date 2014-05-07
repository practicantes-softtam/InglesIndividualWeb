if exists (select 1 from sys.procedures where name = 'spExtensionesCursoUpd')
drop proc spExtensionesCursoUpd
go

create proc spExtensionesCursoUpd
(
@pIdRegistro int out,
	@pClaCampus int,
	@pMatricula varchar(10),
	@pFechaIni smalldatetime,
	@pFechaFin smalldatetime,
	@pComentarios varchar(255),
	@pEstatus int,
	@pClaNivel int,
	@pClaLeccion int,
	@pTipoRegistro tinyInt
	
)
as
begin

	update ExtensionesCurso
	set	ClaCampus = @pClaCampus,
	Matricula = @pMatricula,
	FechaIni = @pFechaIni,
	FechaFin = @pFechaFin,
	Comentarios = @pComentarios,
	Estatus = @pEstatus,
	ClaNivel = @pClaNivel,
	ClaLeccion = @pClaLeccion,
	TipoRegistro = @pTipoRegistro
		
	where IdRegistro = @pIdRegistro

end

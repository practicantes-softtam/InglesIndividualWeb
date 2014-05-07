if exists (select 1 from sys.procedures where name = 'spExtensionesCursoIns')
drop proc spExtensionesCursoIns
go

create proc spExtensionesCursoIns
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

 insert into ExtensionesCurso(ClaCampus, Matricula, FechaIni, FechaFin, Comentarios, Estatus, ClaNivel, ClaLeccion, TipoRegistro) 
 values(@pClaCampus, @pMatricula, @pFechaIni, @pFechaFin, @pComentarios, @pEstatus, @pClaNivel, @pClaLeccion, @pTipoRegistro)
  select @pIdRegistro = @@IDENTITY
end
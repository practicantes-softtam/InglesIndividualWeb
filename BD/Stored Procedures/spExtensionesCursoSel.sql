if exists (select * from sys.procedures where name = 'spExtensionesCursoSel')
begin
	drop proc spExtensionesCursoSel
end

go

CREATE proc spExtensionesCursoSel
(
	@pIdRegistro	int,
	@pClaCampus int,
	@pClaNivel int,
	@pClaLeccion int

)
as
begin

	select	IdRegistro, ClaCampus, Matricula, FechaIni, FechaFin, Comentarios, Estatus, ClaNivel, ClaLeccion, TipoRegistro
 
	from	ExtensionesCurso
	where	
	((IdRegistro =	@pIdRegistro) or @pIdRegistro = -1) and
	((ClaCampus = @pClaCampus) or @pClaCampus = -1) and
	((ClaNivel = @pClaNivel) or @pClaNivel = -1) and
	((ClaLeccion = @pClaLeccion) or @pClaLeccion = -1)
end
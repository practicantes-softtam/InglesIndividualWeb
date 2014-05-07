if exists (select * from sys.procedures where name = 'spExtensionesCursoSel')
begin
	drop proc spExtensionesCursoSel
end

go

CREATE proc spExtensionesCursoSel
(
	@pIdRegistro	int

)
as
begin

	select	IdRegistro, ClaCampus, Matricula, FechaIni, FechaFin, Comentarios, Estatus, ClaNivel, ClaLeccion, TipoRegistro
 
	from	ExtensionesCurso
	where	IdRegistro =	@pIdRegistro
end
if exists (select * from sys.procedures where name = 'spAmpliacionesSel')
begin
	drop proc spAmpliacionesSel
end

go

CREATE proc spAmpliacionesSel
(
	@pIdAmpliacion		int,
	@pClaNivel int,
	@pClaLeccion int
)
as
begin

	select	IdAmpliacion, Matricula, Vigencia, Comentarios, Estatus, ClaNivel, ClaLeccion
 
	from	Ampliaciones
	where	
	((IdAmpliacion	=	@pIdAmpliacion) or @pIdAmpliacion = -1) and
	((ClaNivel	=	@pClaNivel)	or	@pClaNivel = -1) and
	((ClaLeccion	=	@pClaLeccion)	or	@pClaLeccion = -1)
end
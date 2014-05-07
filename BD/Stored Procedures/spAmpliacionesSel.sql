if exists (select * from sys.procedures where name = 'spAmpliacionesSel')
begin
	drop proc spAmpliacionesSel
end

go

CREATE proc spAmpliacionesSel
(
	@pIdAmpliacion		int
)
as
begin

	select	IdAmpliacion, Matricula, Vigencia, Comentarios, Estatus, ClaNivel, ClaLeccion
 
	from	Ampliaciones
	where	IdAmpliacion	=	@pIdAmpliacion
end
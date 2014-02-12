if exists (select 1 from sys.procedures where name = 'spAmpliacionesDel')
drop proc spAmpliacionesDel
go

create proc spAmpliacionesDel
(
	@pIdAmpliacion int
)
as
begin

	delete Ampliaciones
	where IdAmpliacion = @pIdAmpliacion



end
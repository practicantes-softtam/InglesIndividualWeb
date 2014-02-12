if exists (select 1 from sys.procedures where name = 'spAsistenciaLaboratorioDel')
drop proc spAsistenciaLaboratorioDel
go

create proc spAsistenciaLaboratorioDel
(
	@pIdAsistenciaLaboratorio int
)
as
begin

	delete AsistenciaLaboratorio
	where IdAsistenciaLaboratorio = @pIdAsistenciaLaboratorio



end
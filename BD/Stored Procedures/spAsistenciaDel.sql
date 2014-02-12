if exists (select 1 from sys.procedures where name = 'spAsistenciaDel')
drop proc spAsistenciaDel
go

create proc spAsistenciaDel
(
	@pIdRegistro int
)
as
begin

	delete Asistencia
	where IdRegistro = @pIdRegistro



end
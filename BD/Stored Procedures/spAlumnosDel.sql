if exists (select 1 from sys.procedures where name = 'spAlumnosDel')
drop proc spAlumnosDel
go

create proc spAlumnosDel
(
	@pMatricula varchar(10)
)
as
begin

	delete Alumnos 
	where Matricula = @pMatricula



end
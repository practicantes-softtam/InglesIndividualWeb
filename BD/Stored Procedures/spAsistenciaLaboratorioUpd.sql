if exists (select 1 from sys.procedures where name = 'spAsistenciaLaboratorioUpd')
drop proc spAsistenciaUpd
go

create proc spAsistenciaLaboratorioUpd
(
	@pIdAsistenciaLaboratorio int,
	@pClaCampus int,
	@pMatricula varchar(10),
	@pFecha smalldatetime
)
as
begin

	update AsistenciaLaboratorio
	set	ClaCampus = @pClaCampus,
	Matricula = @pMatricula,
	Fecha = @pFecha
		
	where IdAsistenciaLaboratorio = @pIdAsistenciaLaboratorio

end

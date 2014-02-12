if exists (select 1 from sys.procedures where name = 'spAsistenciaLaboratorioIns')
drop proc spAsistenciaLaboratorioIns
go

create proc spAsistenciaLaboratorioIns
(
	@pIdAsistenciaLaboratorio int,
	@pClaCampus int,
	@pMatricula varchar(10),
	@pFecha smalldatetime
)
as 
begin

 insert into AsistenciaLaboratorio (IdAsistenciaLaboratorio, ClaCampus, Matricula, Fecha ) 
 values(@pIdAsistenciaLaboratorio, @pClaCampus, @pMatricula, @pFecha)
 
end
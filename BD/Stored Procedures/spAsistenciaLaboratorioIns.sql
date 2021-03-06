if exists (select 1 from sys.procedures where name = 'spAsistenciaLaboratorioIns')
drop proc spAsistenciaLaboratorioIns
go

create proc spAsistenciaLaboratorioIns
(
	
	@pIdAsistenciaLaboratorio int out,
	@pClaCampus int,
	@pMatricula varchar(10),
	@pFecha smalldatetime
) 
as 
begin

 insert into AsistenciaLaboratorio (ClaCampus, Matricula, Fecha ) 
 values(@pClaCampus, @pMatricula, @pFecha)
 
 --select MAX(IdAsistenciaLaboratorio) From AsistenciaLaboratorio
 select @pIdAsistenciaLaboratorio = @@IDENTITY
end
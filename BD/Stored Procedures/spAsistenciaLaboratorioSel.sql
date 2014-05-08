if exists (select * from sys.procedures where name = 'spAsistenciaLaboratorioSel')
begin
	drop proc spAsistenciaLaboratorioSel
end

go

CREATE proc spAsistenciaLaboratorioSel
(
	@pIdAsistenciaLaboratorio		int,
	@pClaCampus int
)
as
begin

	select	IdAsistenciaLaboratorio, ClaCampus, Matricula, Fecha
 
	from	AsistenciaLaboratorio
	where	
	((IdAsistenciaLaboratorio	=	@pIdAsistenciaLaboratorio) or @pIdAsistenciaLaboratorio = -1) and
	((ClaCampus = @pClaCampus) or @pClaCampus = -1)
end
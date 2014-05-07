if exists (select * from sys.procedures where name = 'spAsistenciaLaboratorioSel')
begin
	drop proc spAsistenciaLaboratorioSel
end

go

CREATE proc spAsistenciaLaboratorioSel
(
	@pIdAsistenciaLaboratorio		int
)
as
begin

	select	IdAsistenciaLaboratorio, ClaCampus, Matricula, Fecha
 
	from	AsistenciaLaboratorio
	where	IdAsistenciaLaboratorio	=	@pIdAsistenciaLaboratorio
end
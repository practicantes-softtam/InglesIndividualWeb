if exists (select 1 from sys.procedures where name = 'spHorarioMaestrosDel')
drop proc spHorarioMaestrosDel
go

create proc spHorarioMaestrosDel
(
	@pClaEmpleado int
	
)
as
begin

	delete HorarioMaestros 
	where ClaEmpleado = @pClaEmpleado

end

exec spHorarioMaestrosDel 10
	select * from HorarioMaestros
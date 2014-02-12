if exists (select 1 from sys.procedures where name = 'spEmpleadosDel')
drop proc spEmpleadosDel
go

create proc spEmpleadosDel
(
	@pClaEmpleado int,
	@pClaCampus int
)
as
begin

	delete Empleados
	where ClaEmpleado = @pClaEmpleado
	AND ClaCampus =@pClaCampus

end
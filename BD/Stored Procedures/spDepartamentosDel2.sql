if exists (select 1 from sys.procedures where name = 'spDepartamentosDel')
drop proc spDepartamentosDel
go

create proc spDepartamentosDel
(
	@ClaDepartamento int
)
as
begin

	delete Departamentos
	where ClaDepartamento = @ClaDepartamento


end

exec spDepartamentosDel 10
	select * from Salones
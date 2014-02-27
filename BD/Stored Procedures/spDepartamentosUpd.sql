if exists (select 1 from sys.procedures where name = 'spDepartamentosUpd')
drop proc spDepartamentosUpd 
go

create proc spDepartamentosUpd
(
	@pClaDepartamento int out,
	@pNomDepartamento varchar (30), 
	@pClaCampus int
	
)
as
begin

	update Departamentos
	set NomDepartamento = @pNomDepartamento,  ClaCampus = @pClaCampus
	
	where ClaDepartamento = @pClaDepartamento
end


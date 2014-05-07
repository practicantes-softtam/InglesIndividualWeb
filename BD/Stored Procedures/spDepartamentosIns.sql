if exists (select 1 from sys.procedures where name = 'spDepartamentosIns')
drop proc spDepartamentosIns
go

create proc spDepartamentosIns
(

	@pClaDepartamento int,
	@pClaCampus int,
	@pNomDepartamento varchar (30)
	
)

as
begin


	insert into Departamentos (ClaDepartamento, ClaCampus, NomDepartamento)
	values (@pClaDepartamento, @pClaCampus, @pNomDepartamento)
	
	
end

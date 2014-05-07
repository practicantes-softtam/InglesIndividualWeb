if exists (select 1 from sys.procedures where name = 'spDepartamentosIns')
drop proc spDepartamentosIns
go

create proc spDepartamentosIns
(

	@pClaDepartamento int out,
	@pClaCampus int,
	@pNomDepartamento varchar (30)
	
)

as
begin


	insert into Departamentos (ClaDepartamento, ClaCampus, NomDepartamento)
	values (@pClaDepartamento, @pClaCampus, @pNomDepartamento)
	
	select @pClaDepartamento = @@IDENTITY
end

declare @clave int
	exec spDepartamentosIns @clave out,  'Departamento de Prueba',1
	select @clave

	select * from Departamentos
if exists (select * from sys.procedures where name = 'spDepartamentosSel')
begin
	drop proc spDepartamentosSel
end

go

CREATE proc spDepartamentosSel
(
	@pClaDepartamento		int,
	@pClaCampus int

)
as
begin

	select	ClaDepartamento, ClaCampus, NomDepartamento
 
	from	Departamentos
	where	
	((ClaDepartamento	=	@pClaDepartamento) or @pClaDepartamento = -1) and
	((ClaCampus = @pClaCampus) or @pClaCampus = -1)
end

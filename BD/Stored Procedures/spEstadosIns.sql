if exists (select 1 from sys.procedures where name = 'spEstadosIns')
drop proc spEstadosIns
go

create proc spEstadosIns
(
	@pClaPais	int,
	@pClaEstado int out,
	@pNomEstado varchar (50)
)
as
begin

	select @pClaEstado = ISNULL (MAX (ClaEstado), 0)+1
	from Estados
	where ClaPais = @pClaPais
	
	insert into Estados (ClaEstado, NomEstado, ClaPais)
	values (@pClaEstado, @pNomEstado, @pClaPais)
	
end
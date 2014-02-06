if exists (select 1 from sys.procedures where name = 'spEstadosIns')
drop proc spEstadosIns
go

create proc spEstadosIns
(
	@pClaEstado int out,
	@pNomEstado varchar (50)
)
as
begin

	select @pClaEstado = ISNULL (MAX (ClaEstado), 0)+1
	from Estados

	insert into Estados (ClaEstado, NomEstado)
	values (@pClaEstado, @pNomEstado)
end
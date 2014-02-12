if exists (select 1 from sys.procedures where name = 'spNivelesDel')
drop proc spNivelesDel
go

create proc spNivelesDel
(
	@pClaNivel	int
)
as
begin

	delete Niveles where ClaNivel = @pClaNivel
	
end
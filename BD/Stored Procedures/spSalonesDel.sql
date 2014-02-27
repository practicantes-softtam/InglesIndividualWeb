if exists (select 1 from sys.procedures where name = 'spSalonesDel')
drop proc spSalonesDel
go

create proc spSalonesDel
(
	@IdSalon int
)
as
begin

	delete Salones
	where IdSalon = @IdSalon


end


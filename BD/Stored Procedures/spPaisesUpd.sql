if exists(select 1 from sys.procedures where name = 'spPaisesUpd')
drop proc spPaisesUpd
go
create proc spPaisesUpd
(
	@pClaPais int,
	@pNomPais varchar(50)
)
as
begin
	update Paises
	set NomPais=@pNomPais
	where ClaPais= @pClaPais

end
 
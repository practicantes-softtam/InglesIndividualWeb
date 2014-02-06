if exists(select 1 from sys.procedures where name = 'spPaisesDel')
drop proc spPaisesDel
go
create proc spPaisesDel(
@pClaPais int
)
as
begin
delete Paises where ClaPais= @pClaPais
end
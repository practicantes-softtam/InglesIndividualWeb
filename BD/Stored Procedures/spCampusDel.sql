if exists(select 1 from sys.procedures where name = 'spCampusDel')
drop proc spCampusDel
go
create proc spCampusDel
(
	@pClaCampus int
)
as
begin

 delete Campus where  ClaCampus = @pClaCampus
    
end
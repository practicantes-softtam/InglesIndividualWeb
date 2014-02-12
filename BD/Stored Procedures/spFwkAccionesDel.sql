if exists(select 1 from sys.procedures where name = 'spFwkAccionesDel')
drop proc spFwkAccionesDel
go
create proc spfwkAccionesDel
(
	@pClaAccion int
)
as
begin

 delete FwkAcciones where  ClaAccion = @pClaAccion
    
end
if exists(select 1 from sys.procedures where name = 'spFwkAplicacionesDel')
drop proc spFwkAplicacionesDel
go
create proc spfwkAplicacionesDel
(
	@pClaAplicacion int
)
as
begin

 delete FwkAplicaciones where  ClaAplicacion= @pClaAplicacion
    
end
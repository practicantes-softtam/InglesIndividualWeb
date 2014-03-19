if exists (select 1 from sys.procedures where name = 'spFwkPerfilesDel')
drop proc spFwkPerfilesDel
go

create proc spFwkPerfilesDel
(
	
	@pClaAplicacion int,
	@pClaPerfil int 
	
)
as
begin

	delete FwkPerfiles 
	where ClaAplicacion= @pClaAplicacion
	AND ClaPerfil= @pClaPerfil


end
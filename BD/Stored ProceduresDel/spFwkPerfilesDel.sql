if exists (select 1 from sys.procedures where name = 'spPerfilesDel')
drop proc spPerfilesDel
go

create proc spPerfilesDel
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
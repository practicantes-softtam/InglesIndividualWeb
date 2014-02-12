
if exists (select 1 from sys.procedures where name = 'spFwkUsuarioPerfilIns')
drop proc spFwkUsuarioPerfilIns
go
create proc spFwkUsuarioPerfilIns
(
	@pIdUsuario varchar (50),
	@pClaAplicacion int,
	@pClaPerfil int
	)
	
as
begin
	
	
	insert into FwkUsuarioPerfil(IdUsuario, ClaAplicacion, ClaPerfil) 
	values (@pIdUsuario, @pClaAplicacion, @pClaPerfil)
       
end

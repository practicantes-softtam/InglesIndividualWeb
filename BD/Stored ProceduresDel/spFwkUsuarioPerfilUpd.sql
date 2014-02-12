
if exists (select 1 from sys.procedures where name = 'spFwkUsuarioPerfilUpd')
drop proc spFwkUsuarioPerfilUpd
go
create proc spFwkUsuarioPerfilUpd
(
	@pIdUsuario varchar (50),
	@pClaAplicacion int,
	@pClaPerfil int
	)
	
as
begin
	
   update  FwkUsuarioPerfil
   set IdUsuario=@pIdUsuario,
     ClaAplicacion=@pClaAplicacion,
     ClaPerfil=@pClaPerfil
   
    where IdUsuario= @pIdUsuario
    AND ClaAplicacion=@pClaAplicacion
    AND ClaPerfil=@pClaPerfil
    
end

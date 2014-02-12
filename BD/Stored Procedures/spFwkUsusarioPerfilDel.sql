
if exists (select 1 from sys.procedures where name = 'spFwkUsuarioPerfilDel')
drop proc spFwkUsuarioPerfilDel
go
create proc spFwkUsuarioPerfilDel
(
	@pIdUsuario varchar (50),
	@pClaAplicacion int,
	@pClaPerfil int
	)
	
as
begin
	
   delete FwkUsuarioPerfil
    where IdUsuario= @pIdUsuario
    AND ClaAplicacion=@pClaAplicacion
    AND ClaPerfil=@pClaPerfil
    
end

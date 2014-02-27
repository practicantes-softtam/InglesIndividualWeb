if exists (select 1 from sys.procedures where name = 'spFwkUsuariosUpd')
drop proc spFwkUsuariosUpd 
go

create proc spFwkUsuariosUpd
(
	@pIdUsuario varchar (50),
	@pNomUsuario varchar (50),
	@pPassword varchar (50),
	@pEmail varchar (100)
)
as
begin

	update FwkUsuarios
	set NomUsuario = @pNomUsuario,
		Password = @pPassword,
		Email = @pEmail
		
	
	where IdUsuario = @pIdUsuario
end


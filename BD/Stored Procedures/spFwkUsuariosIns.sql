if exists (select 1 from sys.procedures where name = 'spFwkUsuariosIns')
drop proc spFwkUsuariosIns
go

create proc spFwkUsuariosIns
(

	@pIdUsuario varchar (50),
	@pNomUsuario varchar (50),
	@pPassword varchar (50),
	@pEmail varchar (100)
	
)
as
begin
	select @pIdUsuario = isnull  (MAX (IdUsuario), 0)+ 1 
	from FwkUsuarios

	insert into FwkUsuarios	(IdUsuario, NomUsuario, Password, Email) 
	values					(@pIdUsuario,	@pNomUsuario,	@pPassword, @pEmail)

end
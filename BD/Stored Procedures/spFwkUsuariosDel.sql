if exists (select 1 from sys.procedures where name = 'spFwkUsuariosDel')
drop proc spFwkUsuariosDel
go

create proc spFwkUsuariosDel
(
	@pIdUsuario int
	
)
as
begin

	delete FwkUsuarios
	where IdUsuario = @pIdUsuario

end

exec spFwkUsuariosDel 10
	select * from FwkUsuarios
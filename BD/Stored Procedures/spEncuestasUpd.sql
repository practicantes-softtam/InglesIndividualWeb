if exists (select 1 from sys.procedures where name = 'spEncuestasUpd')
drop proc spEncuestasUpd
go

create proc spEncuestasUpd
(
	@pClaEncuesta int,
	@pNomEncuesta varchar (50)
	
)
as
begin

	update Encuestas
	set	NomEncuesta = @pNomEncuesta
		
	where ClaEncuesta = @pClaEncuesta

end

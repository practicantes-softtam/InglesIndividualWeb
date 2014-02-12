if exists (select 1 from sys.procedures where name = 'spEncuestasDel')
drop proc spEncuestasDel
go

create proc spEncuestasDel
(
	@pClaEncuesta int

)
as
begin

	delete Encuestas
	where ClaEncuesta = @pClaEncuesta


end
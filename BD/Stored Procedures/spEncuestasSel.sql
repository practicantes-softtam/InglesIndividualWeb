if exists (select * from sys.procedures where name = 'spEncuestasSel')
begin
	drop proc spEncuestasSel
end

go

CREATE proc spEncuestasSel
(
	@pClaEncuesta		int

)
as
begin

	select	ClaEncuesta, NomEncuesta
 
	from	Encuestas
	where	ClaEncuesta =	@pClaEncuesta
end
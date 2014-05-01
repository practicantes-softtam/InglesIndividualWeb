if exists (select * from sys.procedures where name = 'spEstadosSel')
begin
	drop proc spEstadosSel
end

go

CREATE proc spEstadosSel
(
	@pClaPais	int
)
as
begin

	select	ClaPais,
			ClaEstado,
			NomEstado
	from	Estados
	where	((ClaPais	=	@pClaPais)	or	@pClaPais = -1)
end
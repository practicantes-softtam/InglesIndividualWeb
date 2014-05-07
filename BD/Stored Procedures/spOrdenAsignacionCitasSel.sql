if exists (select * from sys.procedures where name = 'spOrdenAsignacionCitasSel')
begin
	drop proc spOrdenAsignacionCitasSel
end

go

CREATE proc spOrdenAsignacionCitasSel
(
	@pClaCampus		int
)
as
begin

	select	ClaCampus,
			ClaProfesor,
			Orden
	
	from	OrdenAsignacionCitas
	where	ClaCampus	=	@pClaCampus
end



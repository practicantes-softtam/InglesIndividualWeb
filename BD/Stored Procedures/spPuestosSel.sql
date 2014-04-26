if exists (select * from sys.procedures where name = 'spPuestosSel')
begin
	drop proc spPuestosSel
end

go

CREATE proc spPuestosSel
(
	@pClaPuesto		int
)
as
begin

	select	ClaPuesto,
			NomPuesto
	from	Puestos 
	where	ClaPuesto	=	@pClaPuesto
end



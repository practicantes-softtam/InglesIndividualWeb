if exists (select * from sys.procedures where name = 'spNivelesSel')
begin
	drop proc spNivelesSel
end

go

CREATE proc spNivelesSel
(
	@pClaNivel	int
)
as
begin

	select		ClaNivel,
				NomNivel,
				ClubConversacion
	
	from	Niveles 
	where	((ClaNivel = @pClaNivel) or @pClaNivel = -1)
end



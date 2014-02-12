if exists (select 1 from sys.procedures where name = 'spNivelesIns')
drop proc spNivelesIns
go

create proc spNivelesIns
(

	@pClaNivel int out,
	@pNomNivel varchar (30),
	@pClubConversacion int
	
)
as
begin
	select @pClaNivel = isnull  (MAX (ClaNivel), 0)+ 1 
	from Niveles

	insert into Niveles	(ClaNivel,		NomNivel,	ClubConversacion) 
	values					(@pClaNivel,	@pNomNivel, @pClubConversacion)

end

declare @clave int
	exec spNivelesIns @clave out, 'Niveles de Prueba',1
	select @clave

	select * from Niveles
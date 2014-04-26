if exists (select 1 from sys.procedures where name = 'spLeccionesIns')
drop proc spLeccionesIns
go

create proc spLeccionesIns
(

	@pClaLeccion		int,
	@pClaNivel			int,
	@pNomLeccion		varchar (30),
	@pEsReview			int
)
as
begin
	
	insert into Lecciones (NomLeccion)
	values (@pNomLeccion)
	select @pClaLeccion = @@IDENTITY
end
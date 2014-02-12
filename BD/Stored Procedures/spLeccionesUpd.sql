if exists (select 1 from sys.procedures where name = 'spLeccionesUpd')
drop proc spLeccionesUpd 
go

create proc spLeccionesUpd
(
	@pClaLeccion int out, 
	@pClaNivel int,
	@pNomLeccion varchar (30),
	@pEsReview tinyint
)
as
begin

	update Lecciones
	set ClaNivel = @pClaNivel, NomLeccion = @pNomLeccion, EsReview = @pEsReview
	
	where ClaLeccion = @pClaLeccion
end

exec spLeccionesUpd 10, 'Lecciones 10'
	select * from Lecciones
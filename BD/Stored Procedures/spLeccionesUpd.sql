if exists (select 1 from sys.procedures where name = 'spLeccionesUpd')
drop proc spLeccionesUpd 
go

create proc spLeccionesUpd
(
	@pClaLeccion		int,
	@pClaNivel			int,
	@pNomLeccion		varchar (30),
	@pEsReview			int
)
as
begin

	update Lecciones
	set NomLeccion = @pNomLeccion, EsReview = @pEsReview, ClaNivel = @pClaNivel
	
	where ClaLeccion = @pClaLeccion

end
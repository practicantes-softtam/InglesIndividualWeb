if exists (select 1 from sys.procedures where name = 'spAmpliacionesUpd')
drop proc spAmpliacionesUpd
go

create proc spAmpliacionesUpd
(
	@pIdAmpliacion int out,
@pMatricula varchar(10),
@pVigencia smalldatetime,
@pComentarios varchar (255),
@pEstatus int,
@pClaNivel int,
@pClaLeccion int
)
as
begin

	update Ampliaciones
	set	Vigencia = @pVigencia,
	Comentarios = @pComentarios,
	Estatus = @pEstatus,
	ClaNivel = @pClaNivel,
	@pClaLeccion = @pClaLeccion
		
	where IdAmpliacion = @pIdAmpliacion

end

if exists (select 1 from sys.procedures where name = 'spLeccionesIns')
drop proc spLeccionesIns
go

create proc spLeccionesIns
(

	@pClaLeccion int out, 
	@pClaNivel int,
	@pNomLeccion varchar (30),
	@pEsReview tinyint
	
)
as
begin
	select @pClaLeccion = isnull  (MAX (ClaLeccion), 0)+ 1 
	from Lecciones

	insert into Lecciones	(ClaLeccion,		ClaNivel,	NomLeccion,		EsReview) 
	values					(@pClaLeccion,	@pClaNivel,	@pNomLeccion, @pEsReview)

end

declare @clave int
	exec spLeccionesIns @clave out, 'Lecciones de Prueba', 1,1
	select @clave

	select * from Lecciones
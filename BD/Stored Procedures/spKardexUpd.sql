if exists (select 1 from sys.procedures where name = 'spKardexUpd')
drop proc spKardexUpd 
go

create proc spKardexUpd
(
	@pIdCalificacion int out,
	@pMatricula varchar (10),
	@pClaCampus int,
	@pClaNivel int,
	@pClaLeccion int,
	@pClaProfesor int,
	@pCalificacion decimal (5),
	@pTipoClase tinyint,
	@pFecha smaldatetime,
	@pClaCalificacion int,
	@pIdCita int
)
as
begin

	update Kardex
	set Matricula = @pMatricula,  ClaCampus = @pClaCampus, ClaNivel = @pClaNivel, ClaLeccion= @pClaLeccion,
		ClaProfesor=@pClaProfesor, Calificacion=@pCalificacion, TipoClase = @pTipoClase, Fecha = @pFecha,
		ClaCalificacion=@pClaCalificacion, IdCita=@pIdCita 
	
	where IdCalificacion = @pIdCalificacion
end

exec spKardexUpd 10, 'Kardex 10', 1,1
	select * from Kardex
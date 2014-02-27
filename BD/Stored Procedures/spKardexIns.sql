if exists (select 1 from sys.procedures where name = 'spKardexIns')
drop proc spKardexIns
go

create proc spKardexIns
(
	@pIdCalificacion int out,
	@pMatricula varchar (10),
	@pClaCampus int,
	@pClaNivel int,
	@pClaLeccion int,
	@pClaProfesor int,
	@pCalificacion decimal (5),
	@pTipoClase tinyint,
	@pFecha smalldatetime,
	@pClaCalificacion int,
	@pIdCita int
)
as
begin

	
	insert into Kardex (IdCalificacion, Matricula, ClaCampus, ClaNivel, ClaLeccion, ClaProfesor, 
						Calificacion, TipoClase, Fecha, ClaCalificacion, IdCita)
	values (@pIdCalificacion, @pMatricula, @pClaCampus, @pClaNivel, @pClaLeccion, @pClaProfesor,
			@pCalificacion, @pTipoClase, @pFecha, @pClaCalificacion, @pIdCita)
	
end


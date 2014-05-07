if exists (select * from sys.procedures where name = 'spKardexSel')
begin
	drop proc spKardexSel
end

go

CREATE proc spKardexSel
(
	@pMatricula varchar (10)
)
as
begin

	select	IdCalificacion,
			Matricula,
			ClaCampus,
			ClaNivel,
			ClaLeccion,
			ClaProfesor,
			Calificacion,
			TipoClase,
			Fecha,
			ClaCalificacion,
			IdCita
			
	from	Kardex 
	where	Matricula	=	@pMatricula
end



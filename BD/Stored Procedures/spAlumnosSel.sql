if exists (select * from sys.procedures where name = 'spAlumnosSel')
begin
	drop proc spAlumnosSel
end

go

CREATE proc spAlumnosSel
(
	@pMatricula		int,
	@pClaPais int,
	@pClaEstado int,
	@pClaCiudad int,
	@pClaCampus int,
	@pClaNivel int,
	@pClaLeccion int,
	@pClaAtendio int
)
as
begin

	select	Matricula, ApPaterno, ApMaterno, Nombre, Sexo, Calle, Colonia, CP, ClaPais, 
  ClaEstado, ClaCiudad, Empresa, Telefono1, Telefono2,Email, Ingreso, Vigencia, Estatus, ClaCampus,
  ClaNivel, ClaLeccion, Suscriptor, ClaAtendio, Contrato, Especial, Observaciones, Foto, FechaNacimiento, Telefono3 
 
	from	Alumnos
	where	
	((Matricula	=	@pMatricula) or @pMatricula = -1) and
	((ClaPais	=	@pClaPais)	or	@pClaPais = -1) and
	((ClaEstado	=	@pClaEstado)	or	@pClaEstado = -1) and
	((ClaCiudad	=	@pClaCiudad)	or	@pClaCiudad = -1) and
	((ClaCampus	=	@pClaCampus)	or	@pClaCampus = -1) and
	((ClaNivel	=	@pClaNivel)	or	@pClaNivel = -1) and
	((ClaLeccion	=	@pClaLeccion)	or	@pClaLeccion = -1) and
	((ClaAtendio	=	@pClaAtendio)	or	@pClaAtendio = -1)

end
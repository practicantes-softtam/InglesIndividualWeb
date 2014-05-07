if exists (select * from sys.procedures where name = 'spAlumnosSel')
begin
	drop proc spAlumnosSel
end

go

CREATE proc spAlumnosSel
(
	@pMatricula		int
)
as
begin

	select	Matricula, ApPaterno, ApMaterno, Nombre, Sexo, Calle, Colonia, CP, ClaPais, 
  ClaEstado, ClaCiudad, Empresa, Telefono1, Telefono2,Email, Ingreso, Vigencia, Estatus, ClaCampus,
  ClaNivel, ClaLeccion, Suscriptor, ClaAtendio, Contrato, Especial, Observaciones, Foto, FechaNacimiento, Telefono3 
 
	from	Alumnos
	where	Matricula	=	@pMatricula
end
if exists (select 1 from sys.procedures where name = 'spOrdenAsignacionCitasIns')
drop proc spOrdenAsignacionCitasIns
go

create proc spOrdenAsignacionCitasIns
(

	@pClaCampus int out, 
	@pClaProfesor int,
	@pOrden int
	
)
as
begin
	select @pClaCampus = isnull  (MAX (ClaCampus), 0)+ 1 
	from OrdenAsignacionCitas

	insert into OrdenAsignacionCitas	(ClaCampus,		ClaProfesor,	Orden) 
	values					(@pClaCampus,	@pClaProfesor,	@pOrden)

end

declare @clave int
	exec spOrdenAsignacionCitasIns @clave out, 'OrdenAsignacionCitas de Prueba', 1
	select @clave

	select * from OrdenAsignacionCitas
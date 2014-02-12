if exists (select 1 from sys.procedures where name = 'spOrdenAsignacionCitasUpd')
drop proc spOrdenAsignacionCitasUpd 
go

create proc spOrdenAsignacionCitasUpd
(
	@pClaCampus int out, 
	@pClaProfesor int,
	@pOrden int
)
as
begin

	update OrdenAsignacionCitas
	set ClaProfesor = @pClaProfesor, Orden = @pOrden
	
	where ClaCampus = @pClaCampus
end

exec spOrdenAsignacionCitasUpd 10, 'OrdenAsignacionCitas 10'
	select * from OrdenAsignacionCitas
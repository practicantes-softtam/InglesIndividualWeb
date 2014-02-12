if exists (select 1 from sys.procedures where name = 'spOrdenAsignacionCitasDel')
drop proc spOrdenAsignacionCitasDel
go

create proc spOrdenAsignacionCitasDel
(
	@pClaCampus	int
)
as
begin

	delete OrdenAsignacionCitas where ClaCampus = @pClaCampus
	
end
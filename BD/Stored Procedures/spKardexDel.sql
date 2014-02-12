if exists (select 1 from sys.procedures where name = 'spKardexDel')
drop proc spKardexDel
go

create proc spKardexDel
(
	@pIdCalificacion	int
)
as
begin

	delete Kardex where IdCalificacion = @pIdCalificacion
	
end
if exists (select 1 from sys.procedures where name = 'spEstadosDel')
drop proc spEstadosDel
go

create proc spEstadosDel
(
	@pClaEstado int,
	@pClaPais	int
)
as
begin

	delete Estados 
	where ClaEstado = @pClaEstado
	and ClaPais = @pClaPais


end
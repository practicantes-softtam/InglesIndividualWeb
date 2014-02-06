if exists (select 1 from sys.procedures where name = 'spEstadosDel')
drop proc spEstadosDel
go

create proc spEstadosDel
(
	@pClaEstado int
)
as
begin

	delete Estados where ClaEstado = @pClaEstado


end
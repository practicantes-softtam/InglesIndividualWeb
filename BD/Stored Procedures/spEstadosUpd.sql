if exists (select 1 from sys.procedures where name = 'spEstadosUpd')
drop proc spEstadosUpd
go

create proc spEstadosUpd
(
	@pClaPais	int,
	@pClaEstado int,
	@pNomEstado varchar (50)
)
as
begin

	update Estados
	set NomEstado =@pNomEstado
	where ClaEstado = @pClaEstado
	and ClaPais = @pClaPais
	
end
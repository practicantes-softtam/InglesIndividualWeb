if exists (select 1 from sys.procedures where name = 'spLeccionesDel')
drop proc spLeccionesDel
go

create proc spLeccionesDel
(
	@pClaLeccion	int
)
as
begin

	delete Lecciones where ClaLeccion = @pClaLeccion
	
end
if exists (select 1 from sys.procedures where name = 'spExtensionesCursoDel')
drop proc spExtensionesCursoDel
go

create proc spExtensionesCursoDel
(
	@pIdRegistro int

)
as
begin

	delete ExtensionesCurso
	where IdRegistro = @pIdRegistro


end
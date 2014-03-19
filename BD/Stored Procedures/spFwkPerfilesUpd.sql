if exists (select 1 from sys.procedures where name = 'spFwkPerfilesUpd')

drop proc spFwkPerfilesUpd
go

create proc spFwkPerfilesUpd
(
	@pClaAplicacion int,
	@pClaPerfil int ,
	@pNomPerfil varchar(50)
)
as
begin

	update FwkPerfiles
	set NomPerfil=@pNomPerfil
	where ClaAplicacion =@pClaAplicacion
	AND ClaPerfil=@pClaPerfil

end
if exists (select 1 from sys.procedures where name = 'spFwkObjetosUpd')

drop proc spFwkObjetosUpd
go

create proc spFwkObjetosUpd
(
@pClaAplicacion int,
@pClaModulo int,
@pClaObjeto int,
@pClaveObjeto varchar(10),
@pNomObjeto varchar(100),
@pUrl varchar (255)
)
as
begin

	update FwkObjetos
	set NomObjeto=@pNomObjeto,
	Url=@pUrl	
	where ClaAplicacion =@pClaAplicacion And
ClaModulo=@pClaModulo And ClaObjeto=@pClaObjeto
end


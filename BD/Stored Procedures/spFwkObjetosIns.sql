if exists (select 1 from sys.procedures where name = 'spFwkObjetosIns')
drop proc spFwkObjetosIns
go

create proc spFwkObjetososIns
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

 insert into FwkObjetos(ClaAplicacion, ClaModulo, ClaObjeto, ClaveObjeto, NomObjeto,Url) 
 values(@pClaAplicacion, @pClaModulo,@pClaObjeto,@pClaveObjeto,@pNomObjeto,@pUrl)
 end
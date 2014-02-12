if exists (select 1 from sys.procedures where name = 'spFwkPerfilesIns')
drop proc spFwkPerfilesIns
go

create proc spFwkPerfilesIns
(
	@pClaAplicacion int,
	@pClaPerfil int ,
	@pNomPerfil varchar(50)
)
as 
begin

 insert into FwkPerfiles (ClaAplicacion, ClaPerfil,	NomPerfil) 
 values(@pClaAplicacion,@pClaPerfil,@pNomPerfil)
 
end

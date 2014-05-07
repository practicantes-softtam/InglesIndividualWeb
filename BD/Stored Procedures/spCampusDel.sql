if exists(select 1 from sys.procedures where name = 'spCampusDel')
drop proc spCampusDel
go
create proc spCampusDel
(
	@pClaCampus int,
	@pClaCiudad int,
	@pClaEstado int, 
	@pClaPais	int
)
as
begin

 delete Campus 
 where  ClaCampus = @pClaCampus
 and ClaCiudad = @pClaCiudad
 and ClaEstado = @pClaEstado
 and ClaPais = @pClaPais
    
end
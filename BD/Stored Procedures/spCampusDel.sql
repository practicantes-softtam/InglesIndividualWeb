if exists(select 1 from sys.procedures where name = 'spCampusDel')
drop proc spCampusDel
go
create proc spCampusDel(
@pClaCampus int,
@pNomCampus varchar(50),
@pCalle varchar(200),
@pColonia varchar(200),
@pCodigoPostal int,
@ClaPais int,
@ClaEstado int,
@ClaCiudad int,
@Telefono varchar(15),
@DirectorGeneral varchar(100),
@DirectorAdministrativo varchar(100)
)
as
begin
 delete Campus where  ClaCampus = @pClaCampus
    
end
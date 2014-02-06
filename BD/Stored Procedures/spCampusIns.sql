if exists(select 1 from sys.procedures where name = 'spCampusIns')
drop proc spCampusIns
go
create proc spCampusIns(
@pClaCampus int  out,
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
select @pClaCampus = ISNULL (Max (ClaCampus),0) +1
 from Campus
insert into Campus(ClaCampus,NomCampus,Calle,Colonia,CodigoPostal,ClaPais,ClaEstado,ClaCiudad,Telefono,DirectorGeneral,DirectorAdministrativo) values(@pClaCampus,@pNomCampus,@pCalle,@pColonia,@pCodigoPostal,@ClaPais,@ClaEstado,@ClaCiudad,@Telefono,@DirectorGeneral,@DirectorAdministrativo)insert into Campus(ClaCampus, NomCampus) values (@pClaCampus,@pNomCampus)   
end

--declare @clave int  
--exec spCampusIns @clave out, 1,'Puesto de prueba'
--select @clave




